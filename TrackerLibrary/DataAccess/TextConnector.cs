using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextConverter;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizeFile = "PrizeModel.csv";

        //TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes =  PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //FInd highest id and add 1.
            int curentId = 1;

            if (prizes.Count > 0)
            {
                curentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = curentId;
            // Add new record with new ID
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizeFile);

            return model; 

        }
    }
}
