using System;  
using System.Collections.Generic;  
using System.Data;  
using System.Data.SqlClient;  
using System.Linq;  
using System.Threading.Tasks;  

  
namespace sampleproject.Models  
{  
    public class HikesDataAccessLayer  
    {  
        string connectionString = "Server=localhost;Database=master;Trusted_Connection=True;";  
  
        //To View all employees details    
        public IEnumerable<Hike> GetAllHikes()  
        {  
            List<Hike> list_hike = new List<Hike>();  
  
            using (SqlConnection con = new SqlConnection(connectionString))  
            {  
                SqlCommand cmd = new SqlCommand("spGetAllHikes", con);  
                cmd.CommandType = CommandType.StoredProcedure;  
  
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    Hike hike = new Hike();  
  
                    hike.ID = Convert.ToInt32(rdr["HikeID"]);  
                    hike.HikeName = rdr["HikeName"].ToString();  
                    hike.Distance = rdr["Distance"].ToString();  
                    hike.HikeLocation = rdr["HikeLocation"].ToString();  
                    hike.ElevationGain = rdr["ElevationGain"].ToString();  
  
                    list_hike.Add(hike);  
                }  
                con.Close();  
            }  
            return list_hike;  
        }  
  
        //To Add new employee record    
        public void AddHike(Hike hike)  
        {  
            using (SqlConnection con = new SqlConnection(connectionString))  
            {  
                SqlCommand cmd = new SqlCommand("spAddHike", con);  
                cmd.CommandType = CommandType.StoredProcedure;  
  
                cmd.Parameters.AddWithValue("@HikeName", hike.HikeName);  
                cmd.Parameters.AddWithValue("@Distance", hike.Distance);  
                cmd.Parameters.AddWithValue("@HikeLocation", hike.HikeLocation);  
                cmd.Parameters.AddWithValue("@ElevationGain", hike.ElevationGain);  
  
                con.Open();  
                cmd.ExecuteNonQuery();  
                con.Close();  
            }  
        }  
  
        //To Update the records of a particluar employee  
        public void UpdateEmployee(Hike hike)  
        {  
            using (SqlConnection con = new SqlConnection(connectionString))  
            {  
                SqlCommand cmd = new SqlCommand("spUpdateHike", con);  
                cmd.CommandType = CommandType.StoredProcedure;  
  
                cmd.Parameters.AddWithValue("@HikeId", hike.ID);  
                cmd.Parameters.AddWithValue("@HikeName", hike.HikeName);  
                cmd.Parameters.AddWithValue("@Distance", hike.Distance);  
                cmd.Parameters.AddWithValue("@HikeLocation", hike.HikeLocation);  
                cmd.Parameters.AddWithValue("@ElevationGain", hike.ElevationGain);  
  
                con.Open();  
                cmd.ExecuteNonQuery();  
                con.Close();  
            }  
        }  
  
        //Get the details of a particular employee  
        public Hike GetHikeData(int? id)  
        {  
            Hike hike = new Hike();  
  
            using (SqlConnection con = new SqlConnection(connectionString))  
            {  
                string sqlQuery = "SELECT * FROM tblHike WHERE HikeID= " + id;  
                SqlCommand cmd = new SqlCommand(sqlQuery, con);  
  
                con.Open();  
                SqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                {  
                    hike.ID = Convert.ToInt32(rdr["HikeID"]);  
                    hike.HikeName = rdr["HikeName"].ToString();  
                    hike.Distance = rdr["Distance"].ToString();  
                    hike.HikeLocation = rdr["HikeLocation"].ToString();  
                    hike.ElevationGain = rdr["ElevationGain"].ToString();  
                }  
            }  
            return hike;  
        }  
  
        //To Delete the record on a particular employee  
        public void DeleteEmployee(int? id)  
        {  
  
            using (SqlConnection con = new SqlConnection(connectionString))  
            {  
                SqlCommand cmd = new SqlCommand("spDeleteHike", con);  
                cmd.CommandType = CommandType.StoredProcedure;  
  
                cmd.Parameters.AddWithValue("@HikeId", id);  
  
                con.Open();  
                cmd.ExecuteNonQuery();  
                con.Close();  
            }  
        }  
    }  
}  