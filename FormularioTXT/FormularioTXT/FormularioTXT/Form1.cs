using System.IO;

namespace FormularioTXT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Salvar
        private void salvarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //variavel para gravar em arquivos
            StreamWriter texto1;

            //definição do caminho e nome do arquivo
            string caminho = "D:\\Anthony\\LPG-Arquivos\\fenascachorras.txt";

            //comando para criar o arquivo no caminho informado
            texto1 = File.CreateText(caminho);

            //escreve o texto digitado no RichBox no arquivo
            texto1.WriteLine(richTextBox1.Text);

            //fecha a ligação com o arquivo
            texto1.Close();
        }
        //Abrir
        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string caminho = "D:\\Anthony\\LPG-Arquivos\\fenascachorras.txt";
            //comando para abrir o bloco de notas com o texto do arquivo
            System.Diagnostics.Process.Start("notepad", caminho);
        }
        //Deletar
        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caminho = "D:\\Anthony\\LGP-Arquivos\\fenascachorras.txt";
            //comando para apagar o arquivo especificado no caminho
            File.Delete(caminho);
        }
        //Cor da Fonte
        private void corDaFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.ForeColor = colorDialog1.Color;
        }
        //Fonte do Texto
        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = richTextBox1.Font;
            fontDialog1.Color = richTextBox1.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fontDialog1.Font;
                richTextBox1.ForeColor = fontDialog1.Color;
            }
        }
    }
}