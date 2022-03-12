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
            string url = "./CreatedFiles";
            DirectoryInfo di = new DirectoryInfo(url);
            treeView1.Nodes.Add(showData(di));
        }

        private TreeNode showData(DirectoryInfo di)
        {
            TreeNode node = new TreeNode(di.Name);
            foreach(var item in di.GetDirectories())
            {
                node.Nodes.Add(showData(item));
            }
            foreach(var item in di.GetFiles())
            {
                node.Nodes.Add(item.Name);
            }
            return node;
        }
    }
}
