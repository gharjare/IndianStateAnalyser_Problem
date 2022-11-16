using IndianStatesAnalyser.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStatesAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }

        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath,string dataHeader)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeader);
            return dataMap;
        }
    }
}
