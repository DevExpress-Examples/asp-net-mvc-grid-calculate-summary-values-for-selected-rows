using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCxGridViewDataBinding.Models
{
    public class MyModel
    {
        public MyModel()
            : this(0)
        {

        }
        public MyModel(int index)
        {
            ModelID = index;
            ModelName = "Name" + index;
            ModelState = index % 2 == 0;
            ModelDate = DateTime.Now;
            if(index < 25)
                Quantity = index + 5  +  index /2;
            else
                Quantity = index + 5 - index/2;
        }
        // Fields...
        private int _Quantity;
        private int _ModelID;
        private string _ModelName;
        private Boolean? _ModelState;
        private DateTime _ModelDate;

        public int ModelID
        {
            get { return _ModelID; }
            set { _ModelID = value; }
        }
        public string ModelName
        {
            get { return _ModelName; }
            set { _ModelName = value; }
        }
        public Boolean? ModelState
        {
            get { return _ModelState; }
            set { _ModelState = value; }
        }
        public DateTime ModelDate
        {
            get { return _ModelDate; }
            set { _ModelDate = value; }
        }

        public int Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        public static List<MyModel> GetModelList()
        {
            List<MyModel> l = new List<MyModel>();
            for (int i = 0; i < 50; i++)
            {
                l.Add(new MyModel(i));
            }
            return l;
        }
        public static void UpdateModel(List<MyModel> l, MyModel m)
        {

            MyModel editedModel = l.Where(x => x.ModelID == m.ModelID).First();
            editedModel.ModelName = m.ModelName;
            editedModel.ModelDate = m.ModelDate;
            editedModel.ModelState = m.ModelState;
        }
        public static void DeleteModel(List<MyModel> l, int mID)
        {
            l.Remove(l.Where(x => x.ModelID == mID).First());
        }
        public static void InsertModel(List<MyModel> l, MyModel m)
        {
            m.ModelID = l.Count + 1;
            l.Add(m);
        }
    }
}