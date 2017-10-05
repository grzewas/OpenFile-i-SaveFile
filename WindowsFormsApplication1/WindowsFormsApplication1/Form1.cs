using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ZAPISZ()
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(textBox1.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = File.ReadAllText(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ZAPISZ();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DialogResult result;
            result = MessageBox.Show("Zapisać?","", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ZAPISZ();
                textBox1.Clear();
            }
            else
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
            DialogResult result;
            result = MessageBox.Show("Zapisać?","", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ZAPISZ();
                Application.Exit();
            }
            else
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Notatnik jest typowym notatnikiem, tylko że to jest mój notatnik, dlatego to najlepszy notatnik na rynku, w dodatku jest to darmowy notatnik. Nigdzie indziej nie znajdziesz takiego dobrego notatnika, jak ten notatnik. Mój notatnik może tworzyć nowy plik w notatniku, zapisywać tekst napisany w notatniku oraz otworzyć plik w notatniku. Korzystaj z jedynego prawdziwego notatnika - z mojego notatnika.");
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Twórcą i pomysłodawcą mojego notatnika jestem ja sam - Grzegorz Wąs.");
        }


        
    }
}
