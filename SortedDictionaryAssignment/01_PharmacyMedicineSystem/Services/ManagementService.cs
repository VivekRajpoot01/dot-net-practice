using System.Collections.Generic;
using System.Linq;
using Domain;
using Exceptions;

namespace Services
{
    public class ManagementService
    {
        private SortedDictionary<int, List<BaseEntity>> _data
            = new SortedDictionary<int, List<BaseEntity>>();

        public void AddEntity(int key, BaseEntity entity)
        {
            entity.Validate();

            // Check duplicate ID
            foreach (var list in _data.Values)
            {
                if (list.Any(x => x.Id == entity.Id))
                    throw new DuplicateMedicineException("Medicine with same ID already exists");
            }

            if (!_data.ContainsKey(key))
                _data[key] = new List<BaseEntity>();

            _data[key].Add(entity);
        }

        public void UpdateEntity(int key, string id, int newPrice)
        {
            if (!_data.ContainsKey(key))
                throw new MedicineNotFoundException("No medicine found");

            var medicine = _data[key]
                .Cast<Medicine>()
                .FirstOrDefault(x => x.Id == id);

            if (medicine == null)
                throw new MedicineNotFoundException("Medicine not found");

            medicine.Price = newPrice;
        }

        public IEnumerable<BaseEntity> GetAll()
        {
            return _data.Values.SelectMany(x => x);
        }
    }
}
