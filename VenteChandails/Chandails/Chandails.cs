/*
        Programmeur: Nathan Comeau
        Date: 12/5/2019
        But:  Ventes de chandails d'équipes de la Ligue Nationale de Hockey
 
        Solution: VenteChandails.sln
        Projet:   Chandails.csproj
        Classe:   Chandails.cs
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chandails
{
    /// <summary>
    /// Couche de metiers de la solution VenteChandails.sln
    /// </summary>
    public class Chandails
    {
        #region Constructeur

        /// <summary>
        /// Constructeur de la classe Chandails.cs
        /// </summary>
        Chandails()
        {

        }

        #endregion

        #region Variables

        private string[] prixChandail;
        private string[] nomEquipes;
        private string[] taillesChandails;

        private string nomClient;
        private DateTime dateTransaction;
        private string nomEquipe;
        private string tailleChoisie;
        private decimal prixTotal;


        #endregion

        #region Propriétés

        /// <summary>
        /// Nom du client (string)
        /// </summary>
        public string Nom
        {
            get
            {
                return nomClient;
            }
            set
            {
                if(value != null)
                {
                    value = value.Trim();
                    if(value != string.Empty)
                    {
                        nomClient = value;
                    }
                    else
                    {
                        throw new ArgumentNullException("Le nom est obligatoire.");
                    }
                }
                else
                {
                    throw new ArgumentNullException("Le nom est obligatoire.");
                }
            }
        }

        /// <summary>
        /// Date de la transaction(DateTime)
        /// </summary>
        public DateTime DateJour
        {
            get
            {
                return dateTransaction;
            }
            set
            {
                if (DateTime.Compare(DateTime.Today.AddDays(15), value) * DateTime.Compare(value, DateTime.Today.AddDays(-15)) > 0)
                {
                    dateTransaction = value;
                    dateTransaction = dateTransaction.AddDays(30);
                }
                else
                    throw new ArgumentOutOfRangeException("Date invalide.");
            }
        }

        /// <summary>
        /// Nom de l'equipe choisie
        /// </summary>
        public string Equipe
        {
            get
            {
                return nomEquipe;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != string.Empty)
                    {
                        nomEquipe = value;
                    }
                    else
                    {
                        throw new ArgumentNullException("Le nom de l'equipe est obligatoire.");
                    }
                }
                else
                {
                    throw new ArgumentNullException("Le nom de l'equipe est obligatoire.");
                }
            }
        }

        /// <summary>
        /// Taille choisie
        /// </summary>
        public string Taille
        {
            get
            {
                return tailleChoisie;
            }
            set
            {
                if (value != null)
                {
                    value = value.Trim();
                    if (value != string.Empty)
                    {
                        tailleChoisie = value;
                    }
                    else
                    {
                        throw new ArgumentNullException("La taille est obligatoire.");
                    }
                }
                else
                {
                    throw new ArgumentNullException("La taille est obligatoire.");
                }
            }
        }

        public decimal Prix
        {
            get
            {
                return prixTotal;
            }
            set
            {
                if (value > 0m)
                {
                    prixTotal = value;
                }
                else
                    throw new ArgumentOutOfRangeException("Le prix est obligatoire.");
            }
        }
        

        #endregion
    }
}
