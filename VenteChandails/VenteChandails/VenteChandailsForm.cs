/*
        Programmeur: Nathan Comeau
        Date: 12/5/2019
        But:  Ventes de chandails d'équipes de la Ligue Nationale de Hockey
 
        Solution: VenteChandails.sln
        Projet:   VenteChandails.csproj
        Classe:   VenteChandailsForm.cs
 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VenteChandails
{
    /// <summary>
    /// Couche de presentation de la solution VenteChandails.sln
    /// </summary>
    public partial class VenteChandailsForm : Form
    {
        public VenteChandailsForm()
        {
            InitializeComponent();
        }

        #region Variables

        private const decimal POURCENTAGE_TAXE = 0.15m;

        #endregion
    }
}
