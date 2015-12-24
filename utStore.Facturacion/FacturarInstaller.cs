using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;


namespace utStore.Facturacion
{
    [RunInstaller(true)]
    public partial class FacturarInstaller : System.Configuration.Install.Installer
    {
        public FacturarInstaller()
        {
            InitializeComponent();
        }
    }
}
