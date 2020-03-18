using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Lab2
{
  public partial class MainWindow : Form
  { 
    BackgroundWorker worker = new BackgroundWorker();
    public MainWindow()
    {
      InitializeComponent();
      Progress.Maximum = 100;
      Progress.Step = 1;  
      worker.WorkerSupportsCancellation = true;
      worker.WorkerReportsProgress = true;
      worker.ProgressChanged += new ProgressChangedEventHandler(WorkerProgresChanged);
      worker.DoWork += new DoWorkEventHandler(WorkerDoWork);
      worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
    }

    private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      Calc.Enabled = true;
    }

    private void WorkerDoWork(object sender, DoWorkEventArgs e)
    {
      for (int i = 0; i < 101; i++)
      {
        ((BackgroundWorker)sender).ReportProgress(i);
        Thread.Sleep(30);
      }
    }

    private void WorkerProgresChanged(object sender, ProgressChangedEventArgs e)
    {
      Progress.Value = e.ProgressPercentage;
    }


    private void Type_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Type.Text == "Шифр Цезаря")
      {
        Shift.Enabled = true;
        KeyWord.Enabled = false;
        KeyWord.Visible = false;
        label4.Visible = false;
      }
      else
      {
        Shift.Enabled = false;
        KeyWord.Enabled = true;
        KeyWord.Visible = true;
        label4.Visible = true;
      }
      Calc.Enabled = true;
      ToolStripOpen.Enabled = true;
    }

    public void ToolStripOpen_Click(object sender, EventArgs e)
    {
      string text;
      if (Type.Text == "DES")
      {
        var openDialog = new OpenFileDialog
        {
          Title = "Открыть",
          CheckFileExists = true,
          CheckPathExists = true,
          Filter = "Файлы DES (*.des)|*.des",
          ShowHelp = true
        };
        if (openDialog.ShowDialog() == DialogResult.OK)
        {
          try
          {
            using (BinaryReader reader = new BinaryReader(File.Open(@openDialog.FileName, FileMode.Open)))
            {
              text = reader.ReadString();
              Start.Text = text;
            }
          }
          catch
          {
            MessageBox.Show("Невозможно открыть файл, попробуйте снова", "Ошибка",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
      else
      {
        var openDialog = new OpenFileDialog
        {
          Title = "Открыть",
          CheckFileExists = true,
          CheckPathExists = true,
          Filter = "Файлы Цезаря (*.caes)|*.caes",
          ShowHelp = true
        };
        if (openDialog.ShowDialog() == DialogResult.OK)
        {
          try
          {
            using (FileStream fileStream = File.OpenRead(@openDialog.FileName))
            {
              text = File.ReadAllText(openDialog.FileName, Encoding.GetEncoding(1251));
              Start.Text = text;
            }
          }
          catch
          {
            MessageBox.Show("Невозможно открыть файл, попробуйте снова", "Ошибка",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }


    private void ToolStripSave_Click(object sender, EventArgs e) // сохранение в разные форматы
    {
      if (Type.Text == "DES")
      {
        var saveDialog = new SaveFileDialog
        {
          Title = "Сохранить как...",
          OverwritePrompt = true, //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
          CheckPathExists = true, //отображать ли предупреждение, если пользователь указывает несуществующий путь
          Filter = "Файлы DES (*.des)|*.des", //список форматов файла, отображаемый в поле "Тип файла"
          ShowHelp = true  //отображается ли кнопка "Справка" в диалоговом окне
        };
        if (saveDialog.ShowDialog() == DialogResult.OK)
        {
          try
          {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@saveDialog.FileName, FileMode.OpenOrCreate)))
            {
              string text = Result.Text;
              writer.Write(text);
              MessageBox.Show("Файл сохранен успешно", "Успех", MessageBoxButtons.OK);
            }
          }
          catch
          {
            MessageBox.Show("Невозможно сохранить файл", "Ошибка",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
      else
      {
        var saveDialog = new SaveFileDialog
        {
          Title = "Сохранить как...",
          OverwritePrompt =
            true, //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
          CheckPathExists = true, //отображать ли предупреждение, если пользователь указывает несуществующий путь
          Filter = "Файлы Цезаря (*.caes)|*.caes", //список форматов файла, отображаемый в поле "Тип файла"
          ShowHelp = true //отображается ли кнопка "Справка" в диалоговом окне
        }; // async c# 5.0
        if (saveDialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
        {
          try
          {
            // запись в файл
            using (FileStream fileStream = new FileStream(@saveDialog.FileName, FileMode.Create))
            {
              string text = Result.Text;
              byte[] array = System.Text.Encoding.Default.GetBytes(text);
              fileStream.Write(array, 0, array.Length);
              MessageBox.Show("Файл сохранен успешно", "Успех", MessageBoxButtons.OK);
            }
          }
          catch
          {
            MessageBox.Show("Невозможно сохранить файл", "Ошибка",
              MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
    }

    private void ToolStripClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ToolStripAbout_Click(object sender, EventArgs e)
    {
      About about = new About();
      about.ShowDialog();
    }

    private void Switch_Click(object sender, EventArgs e)
    {
      string switching = Start.Text;
      Start.Text = Result.Text;
      Result.Text = switching;
    }

    private void Delete_Click(object sender, EventArgs e)
    {
      Result.Text = "";
      ToolStripSave.Enabled = false;
    }

    private void Action_SelectedIndexChanged(object sender, EventArgs e)
    {
      Type.Enabled = true;
    }

    private void Calc_Click(object sender, EventArgs e)
    {
      worker.RunWorkerAsync();
      Calc.Enabled = false;
      if (Start.Text == string.Empty)
      {
        MessageBox.Show("Нет данных для работы программы","Ошибка",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      string text = Start.Text;
      string key = KeyWord.Text;
      if (Action.Text == "Зашифровать")
      {
        if (Type.Text == "DES")
        {
          ICipher cipher = new Des();
          Result.Text = cipher.Encode(Start.Text, Shift.Value, key);
        }
        else
        {
          ICipher cipher = new Caesar();
          Result.Text = cipher.Encode(Start.Text, Shift.Value);
        }
      }
      else if (Action.Text == "Расшифровать")
      {
        if (Type.Text == "DES")
        {
          ICipher cipher = new Des();
          Result.Text = cipher.Decode(Start.Text, Shift.Value, key);
        }
        else
        {
          ICipher cipher = new Caesar();
          Result.Text = cipher.Decode(Start.Text, Shift.Value);
        }
      }
      ToolStripSave.Enabled = true;
    }
  }
}
