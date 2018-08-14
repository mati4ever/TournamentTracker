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
        private const string PeopleFile = "PersonModel.csv";


        public PersonModel CreatePerson(PersonModel model)
        {
            List<PersonModel> people = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;
            if (people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            people.Add(model);

            people.SaveToPeopleFile(PeopleFile);

            return model;
        }

        //TODO - Wire up the CreatePrize for text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            List<PrizeModel> prizes =  PrizeFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            //FInd highest id and add 1.
            int currentId = 1;

            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;
            // Add new record with new ID
            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizeFile);

            return model; 

        }

        public List<PersonModel> GetPerson_All()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }
    }
}
