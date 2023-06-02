using System;
using System.Collections.Generic;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_User
    {
        DAL_User dal_User = new DAL_User();
        public DTO_User getUser(DTO_User dto_User)
        {
            return dal_User.getUser(dto_User, dal_User.GetConn());
        }
        public void AddUser(DTO_User dto_User)
        {
            dal_User.AddUser(dto_User);
        }
        public void UpdateUser(DTO_User dto_User)
        {
            dal_User.UpdateUser(dto_User);
        }
    }
    public class BLL_Pitch
    {
        DAL_Pitch dal_Pitch = new DAL_Pitch();
        public List<DTO_Pitch> getPitchList()
        {
            return dal_Pitch.getPitchList();
        }
        public DTO_Pitch getPrice(DTO_Pitch dto_Pitch)
        {
            return dal_Pitch.getPrice(dto_Pitch);
        }
        public DTO_Pitch getStatus(DTO_Pitch dto_Pitch)
        {
            return dal_Pitch.getStatus(dto_Pitch);
        }
        public void Order(DTO_User dto_User, DTO_Pitch dto_Pitch)
        {
            dal_Pitch.Order(dto_User, dto_Pitch);
        }
        public void Cancel(DTO_User dto_User, DTO_Pitch dto_Pitch)
        {
            dal_Pitch.Cancel(dto_User, dto_Pitch);
        }
        public void AddPitch(DTO_Pitch dto_Pitch)
        {
            dal_Pitch.AddPitch(dto_Pitch);
        }
        public void UpdatePitch(DTO_Pitch dto_Pitch, string NewName)
        {
            dal_Pitch.UpdatePitch(dto_Pitch, NewName);
        }
        public void DeletePitch(DTO_Pitch dto_Pitch)
        {
            dal_Pitch.DeletePitch(dto_Pitch);
        }
    }
    public class BLL_TimeAndPrice
    {
        DAL_TimeAndPrice dal_TimeAndPrice = new DAL_TimeAndPrice();
        public void UpdateTime(int Time)
        {
            dal_TimeAndPrice.UpdateTime(Time);
        }
        public void UpdatePrice(decimal price1, decimal price2, decimal price3, decimal price4)
        {
            dal_TimeAndPrice.UpdatePrice(price1, price2, price3, price4);
        }
    }
}
