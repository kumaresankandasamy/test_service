﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;


namespace SimpleService
{
  [RunInstaller(true)]
  public partial class SimpleServiceInstaller : System.Configuration.Install.Installer
  {
    public SimpleServiceInstaller()
    {
      InitializeComponent();
    }
  }
}
