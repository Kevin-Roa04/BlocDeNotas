using AppCoreTareaBlocNotas.IServices;
using DomainTareaBlocNotas.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
