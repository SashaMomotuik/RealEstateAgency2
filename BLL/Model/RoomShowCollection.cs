using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Model
{
   public  class RoomShowCollection : ObservableCollection<RoomShowViewModel>
    {
        public RoomShowCollection()
        {

        }


        public void AddRoomsShow(ICollection<RoomShowViewModel> roomShow)
        {

            foreach (var item in roomShow)
            {
                Add(new RoomShowViewModel(item));
            }

        }

    }
}
