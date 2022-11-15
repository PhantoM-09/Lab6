using System.Collections.Generic;

namespace Model.Interface
{
    public interface IPhoneDictionary
    {
        void SaveCollection();
        List<PhoneRecord> GetCollection();
        PhoneRecord GetElement(int id);
        void AddElement(PhoneRecord phoneRecord);
        void DeleteElement(int idDeleted);
        void UpdateElement(PhoneRecord phoneRecord);
    }
}
