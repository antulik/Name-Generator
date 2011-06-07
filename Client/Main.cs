using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            
            cmbKey.DataSource = Enum.GetNames(typeof(Keys));



            var Mappings = new List<KeyMapping>();

            var m = new KeyMapping();
            m.Generator = new Generators.Project();
            m.Alt = true;
            m.Hotkey.KeyCode = Keys.D1;
            Mappings.Add(m);

            m = new KeyMapping();
            m.Generator = new Generators.Elf();
            m.Alt = true;
            m.Hotkey.KeyCode = Keys.D2;
            Mappings.Add(m);

            m = new KeyMapping();
            m.Generator = new Generators.Fantasy();
            Mappings.Add(m);


            bsMappings.DataSource = Mappings;
        }

        private void bsMappings_CurrentChanged(object sender, EventArgs e)
        {
        }

        private KeyMapping GetCurrentMapping()
        {
            return bsMappings.Current as KeyMapping;
        }

        private void btnUnreg_Click(object sender, EventArgs e)
        {
            var m = GetCurrentMapping();
            m.UnRegister();
            gvMappings.Refresh();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var m = GetCurrentMapping();
            m.Register(this);
            gvMappings.Refresh();
        }

    }
}

