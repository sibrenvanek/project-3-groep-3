using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app
{
    class data
    {
        public static int Woz(string wijk, int jaar)
        {
            if (wijk == "Overschie")
            {
                if (jaar == 2015)
                    return 154000;
                else if (jaar == 2014)
                    return 157000;
                else if (jaar == 2013)
                    return 155000;
                else if (jaar == 2012)
                    return 163000;
                else if (jaar == 2011)
                    return 165000;
                else if (jaar == 2010)
                    return 161000;
                else if (jaar == 2009)
                    return 163000;
            }
            else if (wijk == "Hillegersberg-Schiebroek")
            {
                if (jaar == 2015)
                    return 241000;
                else if (jaar == 2014)
                    return 245000;
                else if (jaar == 2013)
                    return 251000;
                else if (jaar == 2012)
                    return 258000;
                else if (jaar == 2011)
                    return 260000;
                else if (jaar == 2010)
                    return 261000;
                else if (jaar == 2009)
                    return 265000;
            }
            else if (wijk == "Prins-Alexander")
            {
                if (jaar == 2015)
                    return 174000;
                else if (jaar == 2014)
                    return 178000;
                else if (jaar == 2013)
                    return 181000;
                else if (jaar == 2012)
                    return 192000;
                else if (jaar == 2011)
                    return 194000;
                else if (jaar == 2010)
                    return 196000;
                else if (jaar == 2009)
                    return 198000;
            }
            else if (wijk == "Kralingen-Crooswijk")
            {
                if (jaar == 2015)
                    return 170000;
                else if (jaar == 2014)
                    return 172000;
                else if (jaar == 2013)
                    return 178000;
                else if (jaar == 2012)
                    return 184000;
                else if (jaar == 2011)
                    return 188000;
                else if (jaar == 2010)
                    return 180000;
                else if (jaar == 2009)
                    return 188000;
            }
            else if (wijk == "Centrum")
            {
                if (jaar == 2015)
                    return 167000;
                else if (jaar == 2014)
                    return 169000;
                else if (jaar == 2013)
                    return 172000;
                else if (jaar == 2012)
                    return 180000;
                else if (jaar == 2011)
                    return 191000;
                else if (jaar == 2010)
                    return 177000;
                else if (jaar == 2009)
                    return 184000;
            }
            else if (wijk == "Noord")
            {
                if (jaar == 2015)
                    return 131000;
                else if (jaar == 2014)
                    return 133000;
                else if (jaar == 2013)
                    return 138000;
                else if (jaar == 2012)
                    return 144000;
                else if (jaar == 2011)
                    return 146000;
                else if (jaar == 2010)
                    return 148000;
                else if (jaar == 2009)
                    return 146000;
            }
            else if (wijk == "Delftshaven")
            {
                if (jaar == 2015)
                    return 118000;
                else if (jaar == 2014)
                    return 121000;
                else if (jaar == 2013)
                    return 125000;
                else if (jaar == 2012)
                    return 130000;
                else if (jaar == 2011)
                    return 133000;
                else if (jaar == 2010)
                    return 129000;
                else if (jaar == 2009)
                    return 132000;
            }
            else if (wijk == "Charlois")
            {
                if (jaar == 2015)
                    return 93000;
                else if (jaar == 2014)
                    return 95000;
                else if (jaar == 2013)
                    return 100000;
                else if (jaar == 2012)
                    return 107000;
                else if (jaar == 2011)
                    return 108000;
                else if (jaar == 2010)
                    return 112000;
                else if (jaar == 2009)
                    return 113000;
            }
            else if (wijk == "Feyenoord")
            {
                if (jaar == 2015)
                    return 120000;
                else if (jaar == 2014)
                    return 120000;
                else if (jaar == 2013)
                    return 125000;
                else if (jaar == 2012)
                    return 129000;
                else if (jaar == 2011)
                    return 127000;
                else if (jaar == 2010)
                    return 129000;
                else if (jaar == 2009)
                    return 130000;
            }
            else if (wijk == "Ijsselmonde")
            {
                if (jaar == 2015)
                    return 124000;
                else if (jaar == 2014)
                    return 127000;
                else if (jaar == 2013)
                    return 132000;
                else if (jaar == 2012)
                    return 138000;
                else if (jaar == 2011)
                    return 140000;
                else if (jaar == 2010)
                    return 142000;
                else if (jaar == 2009)
                    return 144000;
            }
            throw new System.ArgumentException("wrong argument(s)");
        }
        public static Nullable<int> Income(string wijk, int jaar)
        {
            if (wijk == "Overschie")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 22100;
                else if (jaar == 2013)
                    return 21300;
                else if (jaar == 2012)
                    return 20900;
                else if (jaar == 2011)
                    return 20600;
                else if (jaar == 2010)
                    return 20000;
                else if (jaar == 2009)
                    return 19300;
            }
            else if (wijk == "Hillegersberg-Schiebroek")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 29000;
                else if (jaar == 2013)
                    return 28100;
                else if (jaar == 2012)
                    return 27800;
                else if (jaar == 2011)
                    return 27300;
                else if (jaar == 2010)
                    return 27000;
                else if (jaar == 2009)
                    return 26500;
            }
            else if (wijk == "Prins-Alexander")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 24200;
                else if (jaar == 2013)
                    return 23700;
                else if (jaar == 2012)
                    return 23400;
                else if (jaar == 2011)
                    return 23200;
                else if (jaar == 2010)
                    return 23000;
                else if (jaar == 2009)
                    return 22500;
            }
            else if (wijk == "Kralingen-Crooswijk")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 23100;
                else if (jaar == 2013)
                    return 21500;
                else if (jaar == 2012)
                    return 21600;
                else if (jaar == 2011)
                    return 21400;
                else if (jaar == 2010)
                    return 21000;
                else if (jaar == 2009)
                    return 21100;
            }
            else if (wijk == "Centrum")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 27700;
                else if (jaar == 2013)
                    return 25700;
                else if (jaar == 2012)
                    return 25500;
                else if (jaar == 2011)
                    return 25500;
                else if (jaar == 2010)
                    return 25000;
                else if (jaar == 2009)
                    return 25200;
            }
            else if (wijk == "Noord")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 21800;
                else if (jaar == 2013)
                    return 21000;
                else if (jaar == 2012)
                    return 20800;
                else if (jaar == 2011)
                    return 20500;
                else if (jaar == 2010)
                    return 21000;
                else if (jaar == 2009)
                    return 20300;
            }
            else if (wijk == "Delftshaven")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 17300;
                else if (jaar == 2013)
                    return 16700;
                else if (jaar == 2012)
                    return 16600;
                else if (jaar == 2011)
                    return 16400;
                else if (jaar == 2010)
                    return 16000;
                else if (jaar == 2009)
                    return 15700;
            }
            else if (wijk == "Charlois")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 17400;
                else if (jaar == 2013)
                    return 17000;
                else if (jaar == 2012)
                    return 17000;
                else if (jaar == 2011)
                    return 16900;
                else if (jaar == 2010)
                    return 17000;
                else if (jaar == 2009)
                    return 16700;
            }
            else if (wijk == "Feyenoord")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 17200;
                else if (jaar == 2013)
                    return 16700;
                else if (jaar == 2012)
                    return 16600;
                else if (jaar == 2011)
                    return 15900;
                else if (jaar == 2010)
                    return 16000;
                else if (jaar == 2009)
                    return 15600;
            }
            else if (wijk == "Ijsselmonde")
            {
                if (jaar == 2015)
                    return null;
                else if (jaar == 2014)
                    return 19400;
                else if (jaar == 2013)
                    return 19000;
                else if (jaar == 2012)
                    return 18800;
                else if (jaar == 2011)
                    return 18600;
                else if (jaar == 2010)
                    return 19000;
                else if (jaar == 2009)
                    return 18100;
            }
            throw new System.ArgumentException("wrong argument(s)");
        }
        public static float FamSize(string wijk, int jaar)
        {
            if (wijk == "Overschie")
            {
                if (jaar == 2015)
                    return 2.1f;
                else if (jaar == 2014)
                    return 2.1f;
                else if (jaar == 2013)
                    return 2f;
                else if (jaar == 2012)
                    return 2f;
                else if (jaar == 2011)
                    return 2f;
                else if (jaar == 2010)
                    return 2f;
                else if (jaar == 2009)
                    return 2.1f;
            }
            else if (wijk == "Hillegersberg-Schiebroek")
            {
                if (jaar == 2015)
                    return 2.1f;
                else if (jaar == 2014)
                    return 2.1f;
                else if (jaar == 2013)
                    return 2.1f;
                else if (jaar == 2012)
                    return 2.1f;
                else if (jaar == 2011)
                    return 2.1f;
                else if (jaar == 2010)
                    return 2.1f;
                else if (jaar == 2009)
                    return 2.1f;
            }
            else if (wijk == "Prins-Alexander")
            {
                if (jaar == 2015)
                    return 2.1f;
                else if (jaar == 2014)
                    return 2.1f;
                else if (jaar == 2013)
                    return 2.1f;
                else if (jaar == 2012)
                    return 2.1f;
                else if (jaar == 2011)
                    return 2.1f;
                else if (jaar == 2010)
                    return 2.1f;
                else if (jaar == 2009)
                    return 2.1f;
            }
            else if (wijk == "Kralingen-Crooswijk")
            {
                if (jaar == 2015)
                    return 1.7f;
                else if (jaar == 2014)
                    return 1.7f;
                else if (jaar == 2013)
                    return 1.7f;
                else if (jaar == 2012)
                    return 1.7f;
                else if (jaar == 2011)
                    return 1.7f;
                else if (jaar == 2010)
                    return 1.8f;
                else if (jaar == 2009)
                    return 1.8f;
            }
            else if (wijk == "Centrum")
            {
                if (jaar == 2015)
                    return 1.6f;
                else if (jaar == 2014)
                    return 1.6f;
                else if (jaar == 2013)
                    return 1.6f;
                else if (jaar == 2012)
                    return 1.6f;
                else if (jaar == 2011)
                    return 1.5f;
                else if (jaar == 2010)
                    return 1.6f;
                else if (jaar == 2009)
                    return 1.6f;
            }
            else if (wijk == "Noord")
            {
                if (jaar == 2015)
                    return 1.8f;
                else if (jaar == 2014)
                    return 1.8f;
                else if (jaar == 2013)
                    return 1.8f;
                else if (jaar == 2012)
                    return 1.8f;
                else if (jaar == 2011)
                    return 1.7f;
                else if (jaar == 2010)
                    return 1.8f;
                else if (jaar == 2009)
                    return 1.8f;
            }
            else if (wijk == "Delftshaven")
            {
                if (jaar == 2015)
                    return 1.9f;
                else if (jaar == 2014)
                    return 1.9f;
                else if (jaar == 2013)
                    return 1.9f;
                else if (jaar == 2012)
                    return 1.9f;
                else if (jaar == 2011)
                    return 1.9f;
                else if (jaar == 2010)
                    return 2f;
                else if (jaar == 2009)
                    return 2f;
            }
            else if (wijk == "Charlois")
            {
                if (jaar == 2015)
                    return 1.9f;
                else if (jaar == 2014)
                    return 1.9f;
                else if (jaar == 2013)
                    return 1.9f;
                else if (jaar == 2012)
                    return 1.9f;
                else if (jaar == 2011)
                    return 1.9f;
                else if (jaar == 2010)
                    return 1.9f;
                else if (jaar == 2009)
                    return 1.9f;
            }
            else if (wijk == "Feyenoord")
            {
                if (jaar == 2015)
                    return 2f;
                else if (jaar == 2014)
                    return 2f;
                else if (jaar == 2013)
                    return 2f;
                else if (jaar == 2012)
                    return 2f;
                else if (jaar == 2011)
                    return 2f;
                else if (jaar == 2010)
                    return 2.1f;
                else if (jaar == 2009)
                    return 2.1f;
            }
            else if (wijk == "Ijsselmonde")
            {
                if (jaar == 2015)
                    return 2f;
                else if (jaar == 2014)
                    return 2f;
                else if (jaar == 2013)
                    return 2f;
                else if (jaar == 2012)
                    return 2f;
                else if (jaar == 2011)
                    return 2f;
                else if (jaar == 2010)
                    return 2f;
                else if (jaar == 2009)
                    return 2f;
            }
            throw new System.ArgumentException("wrong argument(s)");
        }
        public static float Satisfaction(string wijk, int jaar)
        {
            if (wijk == "Overschie")
            {
                if (jaar == 2015)
                    return 79.9f;
                else if (jaar == 2014)
                    return 79.9f;
                else if (jaar == 2013)
                    return 79.9f;
                else if (jaar == 2012)
                    return 79.9f;
                else if (jaar == 2011)
                    return 79.9f;
                else if (jaar == 2010)
                    return 79.9f;
                else if (jaar == 2009)
                    return 79.9f;
            }
            else if (wijk == "Hillegersberg-Schiebroek")
            {
                if (jaar == 2015)
                    return 88.7f;
                else if (jaar == 2014)
                    return 88.7f;
                else if (jaar == 2013)
                    return 88.7f;
                else if (jaar == 2012)
                    return 88.7f;
                else if (jaar == 2011)
                    return 88.7f;
                else if (jaar == 2010)
                    return 88.7f;
                else if (jaar == 2009)
                    return 88.7f;
            }
            else if (wijk == "Prins-Alexander")
            {
                if (jaar == 2015)
                    return 84.6f;
                else if (jaar == 2014)
                    return 84.6f;
                else if (jaar == 2013)
                    return 84.6f;
                else if (jaar == 2012)
                    return 84.6f;
                else if (jaar == 2011)
                    return 84.6f;
                else if (jaar == 2010)
                    return 84.6f;
                else if (jaar == 2009)
                    return 84.6f;
            }
            else if (wijk == "Kralingen-Crooswijk")
            {
                if (jaar == 2015)
                    return 76.1f;
                else if (jaar == 2014)
                    return 76.1f;
                else if (jaar == 2013)
                    return 76.1f;
                else if (jaar == 2012)
                    return 76.1f;
                else if (jaar == 2011)
                    return 76.1f;
                else if (jaar == 2010)
                    return 76.1f;
                else if (jaar == 2009)
                    return 76.1f;
            }
            else if (wijk == "Centrum")
            {
                if (jaar == 2015)
                    return 82.9f;
                else if (jaar == 2014)
                    return 82.9f;
                else if (jaar == 2013)
                    return 82.9f;
                else if (jaar == 2012)
                    return 82.9f;
                else if (jaar == 2011)
                    return 82.9f;
                else if (jaar == 2010)
                    return 82.9f;
                else if (jaar == 2009)
                    return 82.9f;
            }
            else if (wijk == "Noord")
            {
                if (jaar == 2015)
                    return 75.2f;
                else if (jaar == 2014)
                    return 75.2f;
                else if (jaar == 2013)
                    return 75.2f;
                else if (jaar == 2012)
                    return 75.2f;
                else if (jaar == 2011)
                    return 75.2f;
                else if (jaar == 2010)
                    return 75.2f;
                else if (jaar == 2009)
                    return 75.2f;
            }
            else if (wijk == "Delftshaven")
            {
                if (jaar == 2015)
                    return 65.7f;
                else if (jaar == 2014)
                    return 65.7f;
                else if (jaar == 2013)
                    return 65.7f;
                else if (jaar == 2012)
                    return 65.7f;
                else if (jaar == 2011)
                    return 65.7f;
                else if (jaar == 2010)
                    return 65.7f;
                else if (jaar == 2009)
                    return 65.7f;
            }
            else if (wijk == "Charlois")
            {
                if (jaar == 2015)
                    return 60.7f;
                else if (jaar == 2014)
                    return 60.7f;
                else if (jaar == 2013)
                    return 60.7f;
                else if (jaar == 2012)
                    return 60.7f;
                else if (jaar == 2011)
                    return 60.7f;
                else if (jaar == 2010)
                    return 60.7f;
                else if (jaar == 2009)
                    return 60.7f;
            }
            else if (wijk == "Feyenoord")
            {
                if (jaar == 2015)
                    return 64.7f;
                else if (jaar == 2014)
                    return 64.7f;
                else if (jaar == 2013)
                    return 64.7f;
                else if (jaar == 2012)
                    return 64.7f;
                else if (jaar == 2011)
                    return 64.7f;
                else if (jaar == 2010)
                    return 64.7f;
                else if (jaar == 2009)
                    return 64.7f;
            }
            else if (wijk == "Ijsselmonde")
            {
                if (jaar == 2015)
                    return 70.1f;
                else if (jaar == 2014)
                    return 70.1f;
                else if (jaar == 2013)
                    return 70.1f;
                else if (jaar == 2012)
                    return 70.1f;
                else if (jaar == 2011)
                    return 70.1f;
                else if (jaar == 2010)
                    return 70.1f;
                else if (jaar == 2009)
                    return 70.1f;
            }
            throw new System.ArgumentException("wrong argument(s)");
        }
    }
}
