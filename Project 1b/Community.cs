using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Community
    {
        /// <summary>
        /// Fields of the class Comunity: country name, date, new cases per 100K, and positivity rate.
        /// </summary>
        #region Fields
        private string _countryName;
        private DateTime _date;
        private int _newCasesX100;
        private int _positivityRate;
        #endregion

        /// <summary>
        /// Properties of the class Comunity:status, color, country name, date, new cases per 100K, and positivity rate.
        /// </summary>
        #region Properties
        public string CountryName
        {
            get { return _countryName; }
            set { _countryName = value.Trim(); }
        }

        public DateTime Date { get; set; }

        public int NewCasesX100 { get; set; }

        public int PositivityRate { get; set; }

        public double Status
        {
            get { return ((double)NewCasesX100 / 100000) * 100; }
        }

        public double Color { get; }
        #endregion

        /// <summary>
        /// Constructors of the class Community
        /// </summary>
        #region Constructors and destructors
        //default constructor
        public Community()
        {
            CountryName = string.Empty;
            NewCasesX100 = 0;
            PositivityRate = 0;
        }

        //overloaded constructor
        public Community(string pCountryName, DateTime pDate, int pNewCasesX100, int pPositivityRate)
        {
            CountryName = pCountryName;
            Date = pDate;
            NewCasesX100 = pNewCasesX100;
            PositivityRate = pPositivityRate;
            
        }

        ~Community()
        {
            _countryName = null;
        }

        #endregion

        /// <summary>
        /// Methods of the class Community
        /// </summary>
        #region Methods
        public override string ToString()
        {
            string message;
            message = Status.ToString();
                //"In " + CountryName.ToUpper() + " there are " + NewCasesX100 + " with a positivity rate of " + 
               // PositivityRate + Environment.NewLine + "Submmited on: " + Date;
            return message;
        }
        #endregion
    }
}
