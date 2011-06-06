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
            m.Generator = new Generators.GProjectName();
            Mappings.Add(m);

            m = new KeyMapping();
            m.Generator = new Generators.GElfName();
            Mappings.Add(m);

            m = new KeyMapping();
            m.Generator = new Generators.GFantasyName();
            Mappings.Add(m);


            bsMappings.DataSource = Mappings;
        }

        private void bsMappings_CurrentChanged(object sender, EventArgs e)
        {
            //var m = GetCurrentMapping();

            //chkAlt.Checked = m.Hotkey.Alt;
            //chkCtrl.Checked = m.Hotkey.Control;
            //chkShift.Checked = m.Hotkey.Shift;
            //chkWin.Checked = m.Hotkey.Windows;
            ///cmbKey.SelectedText = m.Hotkey.ToString();
            
        }

        private KeyMapping GetCurrentMapping()
        {
            return bsMappings.Current as KeyMapping;
        }

        private void btnUnreg_Click(object sender, EventArgs e)
        {
            var m = GetCurrentMapping();
            m.UnRegister();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            var m = GetCurrentMapping();
            m.Register(this);
        }

    }
}

