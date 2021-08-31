using UnityEngine;

namespace ParadiseVille.Handler
{
    internal class DataOutput
    {
        TextDraw writer;
        QuartierData qData;

        Color headColor;
        Color textColor;

        public DataOutput(ref TextDraw writer, ref QuartierData qData)
        {
            this.writer = writer;
            this.qData = qData;

            headColor = Color.red;
            textColor = Color.black;
        }

        public void HeadData(float startX, float startY)
        {
            string[] names = qData.Names;
            int length = names.Length;

            float[] posY = new float[3]
            {
                startY,
                startY + 80f,
                startY + 130f
            };

            for (int i = 0; i < length; i++)
            {
                writer.TextWrite(names[i], startX, Y(i), Size(i), ColorText(i));
            }

            float Y(int i)
            {
                return posY[i];
            }

            int Size(int i)
            {
                if (i == 0)
                {
                    return 60;
                }

                return 40;
            }

            Color ColorText(int i)
            {
                if (i == 0)
                {
                    return headColor;
                }

                return textColor;
            }
        }

        public void MainData(float startX, float startY)
        {
            float square = Mathf.Round(qData.Square * 10f) / 10f;
            int resCount = qData.CountResidents;
            int empCount = qData.CountEmployers;

            float dencGeneral = Mathf.RoundToInt(resCount / square) * 100;
            float dencActive = Mathf.RoundToInt((empCount + (resCount / 2)) / square) * 100;

            writer.TextWrite("COMMUNAUTÉ", startX, startY, 40, headColor);
            writer.TextWrite("Résidents", resCount.ToString(), startX, startY + 60f, 25, textColor);
            writer.TextWrite("Employés", empCount.ToString(), startX, startY + 90f, 25, textColor);
            writer.TextWrite("Superficie", square.ToString(), startX, startY + 120f, 25, textColor);
            writer.TextWrite("Densité repos", dencGeneral.ToString(), startX, startY + 150f, 25, textColor);
            writer.TextWrite("Densité actif", dencActive.ToString(), startX, startY + 180f, 25, textColor);
            writer.TextWrite("Député", qData.Depute.ToString(), startX, startY + 210f, 25, textColor);
        }

        public void EmployersDataNoZero(float startX, float startY)
        {
            string[] keys = qData.EmployerGroupNames;
            int[] workers = qData.EmployerGroupCount;
            int length = keys.Length;
            int writed = 0;

            writer.TextWrite("EMPLOI", startX, startY, 40, headColor);

            for (int i = 0; i < length; i++)
            {
                if (workers[i] > 0)
                {
                    writer.TextWrite(keys[i], workers[i].ToString(), startX, startY + 60f + 30f * writed, 25, textColor);
                    writed++;
                }
            }
        }

        public void EmployersData(float startX, float startY)
        {
            string[] keys = qData.EmployerGroupNames;
            int[] workers = qData.EmployerGroupCount;
            int[] workersPart = qData.EmployerGroupParts;
            int length = keys.Length;

            writer.TextWrite("EMPLOI", startX, startY, 40, headColor);

            for (int i = 0; i < length; i++)
            {
                writer.TextWrite(keys[i], workers[i].ToString(), workersPart[i].ToString(), startX, startY + 60f + 30f * i, 25, textColor);
            }
        }

        public void PublicPlacesData(float startX, float startY)
        {
            writer.TextWrite("ESPACE PUBLIC", startX, startY, 40, headColor);

            string[] publics = qData.EspacePublic;
            int count = publics.Length;

            for (int i = 0; i < count; i++)
            {
                writer.TextWrite(publics[i], startX, startY + 60f + 30f * i, 25, textColor);
            }
        }
        
        public void SocialData(float startX, float startY)
        {
            int[] socAbs = qData.SocialGroups;
            int[] socPer = qData.SocialGroupsPercent;

            writer.TextWrite("SOCIÉTÉ", startX, startY, 40, headColor);
            writer.TextWrite("Ouvrier", socAbs[0].ToString(), socPer[0].ToString(), startX, startY + 60f, 25, textColor);
            writer.TextWrite("Spécialiste", socAbs[1].ToString(), socPer[1].ToString(), startX, startY + 90f, 25, textColor);
            writer.TextWrite("Professionnel", socAbs[2].ToString(), socPer[2].ToString(), startX, startY + 120f, 25, textColor);
            writer.TextWrite("Responsable", socAbs[3].ToString(), socPer[3].ToString(), startX, startY + 150f, 25, textColor);
        }

        public void EtagesData(float startX, float startY)
        {
            int[] etages = qData.Etages;
            int[] etagesPart = qData.EtagesPercent;
            int count = etages.Length;

            writer.TextWrite("ÉTAGES", startX, startY, 40, headColor);
            
            for (int i = 0; i < count; i++)
            {
                writer.TextWrite((i + 1).ToString(), etages[i].ToString(), etagesPart[i].ToString(),
                    startX, startY + 60f + 30f * i, 25, textColor);
            }
        }
    }
}
