using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestAppRestaurant.Data;
using TestAppRestaurant.Models;
using TestAppRestaurant.ViewModel;

namespace TestAppRestaurant.Repository
{
    public class FoodOrderRepository : IRepository<FoodOrderViewModel>
    {
        DBConnection db = new DBConnection();

        public void Add(FoodOrderViewModel obj)
        {
            try
            {

                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@FoodName", obj.FoodName);
                param.Add("@Quantity", obj.Quantity);
                param.Add("@Price", obj.Price);
                param.Add("@ServiceCharge", obj.ServiceCharge);
                param.Add("@VAT", obj.VAT);
                param.Add("@Total", obj.Total);
                param.Add("@OrderDate", DateTime.Now);
                param.Add("@isDelivered", obj.IsDelivered);
                db.con.Execute("spAddFoodOrder", param, commandType: System.Data.CommandType.StoredProcedure);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.con.Close();
            }
        }

        public void Delete(int id)
        {
            try
            {
                //var deletedBy = "Admin";
                //DateTime deletedDate = DateTime.Now;
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                //var foodOrder = getbyId(id);

                param.Add("@id", id);
                //param.Add("@FoodName", foodOrder.FoodName);
                //param.Add("@Quantity", foodOrder.Quantity);
                //param.Add("@Price", foodOrder.Price);
                //param.Add("@ServiceCharge", foodOrder.ServiceCharge);
                //param.Add("@VAT", foodOrder.VAT);
                //param.Add("@Total", foodOrder.Total);
                //param.Add("@OrderDate", foodOrder.OrderedDate);
                //param.Add("@isDelivered", foodOrder.IsDelivered);
                //param.Add("@deletedBy", deletedBy);
                //param.Add("@deletedDate", deletedDate);
                //param.Add("@flag", "delete");
                //db.con.Execute("spAddFoodOrderLog", param, commandType: System.Data.CommandType.StoredProcedure);
                db.con.Execute("spDeleteFoodOrder", param, commandType: System.Data.CommandType.StoredProcedure);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.con.Close();
            }
        }

        public void Edit(FoodOrderViewModel obj)
        {
            try
            {
                //var editedBy = "Admin";
                //DateTime editedDate = DateTime.Now;
                db.connection();
                db.con.Open();
                DynamicParameters param = new DynamicParameters();
                param.Add("@FoodOrderID", obj.FoodOrderID);
                param.Add("@FoodName", obj.FoodName);
                param.Add("@Quantity", obj.Quantity);
                param.Add("@Price", obj.Price);
                param.Add("@ServiceCharge", obj.ServiceCharge);
                param.Add("@VAT", obj.VAT);
                param.Add("@Total", obj.Total);
                param.Add("@OrderDate", obj.OrderedDate);
                param.Add("@isDelivered", obj.IsDelivered);
                //param.Add("@editedBy", editedBy);
                //param.Add("@editedDate", editedDate);
                //param.Add("@flag", "edit");
                
                //db.con.Execute("spAddFoodOrderLog", param, commandType: System.Data.CommandType.StoredProcedure);
                db.con.Execute("spUpdateFoodOrder", param, commandType: System.Data.CommandType.StoredProcedure);

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.con.Close();
            }
        }

        public FoodOrderViewModel getbyId(int? id)
        {
            try
            {
                db.connection();
                db.con.Open();
                DynamicParameters parm = new DynamicParameters();
                parm.Add("@id", id);
                var data = SqlMapper.Query<FoodOrderViewModel>(db.con, "spGetByID", parm, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return data;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                db.con.Close();
            }
        }

        public List<FoodModel> getFoodList()
        {
            db.connection();
            db.con.Open();
            var data = SqlMapper.Query<FoodModel>(db.con, "spGetAllFood", commandType: System.Data.CommandType.StoredProcedure).ToList();
            db.con.Close();
            return data;
        }
        public List<FoodOrderViewModel> List()
        {
            db.connection();
            db.con.Open();
            var data = SqlMapper.Query<FoodOrderViewModel>(db.con, "spGetAllFoodOrderList", commandType: System.Data.CommandType.StoredProcedure).ToList();
            db.con.Close();
            return data;
        }
    }
}