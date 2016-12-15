using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using healthcare_timeline.Models;
using System.Data.Sql;
using System.Data.SqlClient;

namespace healthcare_timeline.DataAccess
{
    public class FitnessInfoDal
    {

        public void AddFitnessData(FitnessDataViewModel fitnessData, string userId)
        {
            string sqltext = string.Format("Insert into User_FitnessDetails (User_ID, Height,Weight,WeightDate,DailySteps,DailyStepsDate) " +
                                           "values('{0}',{1},{2},'{3}',{4},'{5}') ",
                                userId, fitnessData.Height, fitnessData.Weight, fitnessData.WeightDate.ToString("yyyy-MM-dd"),
                                fitnessData.DailySteps, fitnessData.DailyStepsDate.ToString("yyyy-MM-dd"));

            using (
                var connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
                )
            {
                using (
                    var command = new SqlCommand(sqltext, connection)
                    )
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<float> GetFitnessData(string userId)
        {
            string sqltext = string.Format("Select Top 7 Weight FROM User_FitnessDetails " +
                                           "WHERE User_ID = '{0}' AND Weight IS NOT NULL ORDER BY WeightDate",
                                userId);
            var fitnessDataArray = new List<float>();

            using (
                var connection =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
                )
            {
                using (
                    var command = new SqlCommand(sqltext, connection)
                    )
                {
                    connection.Open();
                    using (
                        var reader = command.ExecuteReader()
                        )
                    {
                        while (reader.Read())
                        {
                            fitnessDataArray.Add( (float)reader.GetDecimal(0));
                        }
                    };
                }
            }

            return fitnessDataArray;
        }
    }
}