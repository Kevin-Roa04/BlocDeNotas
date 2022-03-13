using AppCoreTareaBlocNotas.IServices;
using DomainTareaBlocNotas.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioTareaBlocNotas
{
    public partial class Form1 : Form
    {
        public IBlocNotasService blocNotasService;
        public Form1(IBlocNotasService blocNotasService)
        {
            this.blocNotasService = blocNotasService;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTV();
        }

        //Muestra la informacion del TreeView
        private void dataTV()
        {
            treeView1.Nodes.Clear();
            string url = "./CreatedFiles";
            DirectoryInfo di = new DirectoryInfo(url);
            treeView1.Nodes.Add(showData(di));
            treeView1.Nodes[0].Expand();
        }

        private TreeNode showData(DirectoryInfo di)
        {
            TreeNode treeNode = new TreeNode(di.Name);
            string path = di.FullName;
            treeNode.Tag = path;

            foreach(var items in di.GetFiles())
            {
                if (items.Name.Contains(".txt"))
                {
                    TreeNode file = new TreeNode(items.Name);
                    file.Tag = items.FullName;
                    treeNode.Nodes.Add(file);
                }
            }
            foreach(var items in di.GetDirectories())
            {
                treeNode.Nodes.Add(showData(items));
            }
            return treeNode;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notepad.Visible = true;
        }

        private void carpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string carpeta = treeView1.SelectedNode.Tag.ToString();
            DirectoryInfo di = new DirectoryInfo(carpeta);
            if (di.Attributes.HasFlag(FileAttributes.Directory))
            {
                //Si es una carpeta...
                string dirName;
                do
                {
                    dirName = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre de la Carpeta que Desea Crear", "Nombre del Directorio");
                } while (dirName.Length == 0);

                Directory.CreateDirectory(carpeta + "/" + dirName);
                dataTV();
                return;
            }
            //si es un archivo se manda un mensaje de error
            MessageBox.Show("El elemento seleccionado es un archivo, Intente nuevamente....",
                "ERROR");
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string carpeta = treeView1.SelectedNode.Tag.ToString();
            DirectoryInfo di = new DirectoryInfo(carpeta);

            if (di.Attributes.HasFlag(FileAttributes.Directory))
            {
                //Si es una carpeta...
                string dirName = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Nombre ", "Registro de Datos Personales", "Nombre", 100, 0);

                File.Create(carpeta + "/" + dirName + ".txt");
                dataTV();
                return;
            }

            //si es un archivo se manda un mensaje de error
            MessageBox.Show("El elemento seleccionado es un archivo, Intente nuevamente....",
                "ERROR");

            /*BlocNotas blocNotas = new BlocNotas()
            {
                Texto = "",
                Titulo = "Adios.txt",
            };
            blocNotasService.Add(blocNotas);*/

            dataTV();
        }

        private void cmsOpciones_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dir = treeView1.SelectedNode.Tag.ToString();
            DirectoryInfo dirInfo = new DirectoryInfo(dir);
            if (dirInfo.Attributes.HasFlag(FileAttributes.Directory))
            {
                //si es un directorio
                Directory.Delete(dir, true);
                dataTV();
                return;
            }
            //si es un archivo
            File.Delete(dir);
        }
    }
}
