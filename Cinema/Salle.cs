using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Salle
    {
        private int numeroSalle;
        private string titre;
        private int nmbPlace;
        private double prixUnitaire;
        private int nmbPlaceTarifN = 0;
        private int nmbPlaceTarifR = 0;

        // Constructeur de Salle
        public Salle(string unTitre, int unNmbPLace, double unPrixUnitaire)
        {
            this.Titre = unTitre;
            this.NmbPlace = unNmbPLace;
            this.PrixUnitaire = unPrixUnitaire;
        }

        public string Titre { get => titre; set => titre = value; }
        public int NmbPlace { get => nmbPlace; set => nmbPlace = value; }
        public double PrixUnitaire { get => prixUnitaire; set => prixUnitaire = value; }
        public int NmbPlaceTarifN { get => nmbPlaceTarifN; set => nmbPlaceTarifN = value; }
        public int NmbPlaceTarifR { get => nmbPlaceTarifR; set => nmbPlaceTarifR = value; }
        public int NumeroSalle { get => numeroSalle; set => numeroSalle = value; }

        public int nbPlacesDisponibles()
        {
            int placeDispo = NmbPlace - (NmbPlaceTarifN + NmbPlaceTarifR);
            return placeDispo;
        }

        public void vendrePlaces(int nbre, bool tarifReduit)
        {
            if (nbre > nmbPlace)
            {
                return "La vente n'est pas disponible";
            }
            else
            {
                if (tarifReduit == true)
                {
                    prixUnitaire = nbre * (prixUnitaire * 0.20);
                    return "Le prix est de" + prixUnitaire + " €";
                }
                else
                {
                    prixUnitaire = nbre * prixUnitaire;
                    return "Le prix est de" + prixUnitaire + " €";
                }
            }
        }

        public void remiseAZero()
        {
            nmbPlace = 0;
        }

        public double chiffreAffaires()
        {
            double ca = prixUnitaire * nmbPlaceTarifN;
            double ca2 = (prixUnitaire * nmbPlaceTarifR) * 0.20;
            double caF = ca + ca2;
            return caF;
        }
    }
}
