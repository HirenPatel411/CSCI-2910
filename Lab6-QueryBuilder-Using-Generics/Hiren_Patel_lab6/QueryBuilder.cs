using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Data.Sqlite;
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  Lab 6
//	File Name:         QueryBuilder.cs
//	Course:            CSCI 2910	
//	Created:           Tuesday, June 22, 2021
//  Author:            Hiren Patel, patelhm@etsu.edu
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace Hiren_Patel_lab6
{
    class QueryBuilder : IDisposable
    {
        private SqliteConnection connection;

        public QueryBuilder(SqliteConnection connection)
        {
            this.connection = connection;
        }

        /// <summary>
        ///This method takes any type (T) and makes a new instance. Also reads one single row in the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Read<T>(int id) where T : IClassModel, new()
        {
            SqliteCommand command = connection.CreateCommand();
            command.CommandText = $"select * from {typeof(T).Name} where Id = {id}";
            SqliteDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                throw new Exception(" Error. There are zero rows.");
            }

            PropertyInfo[] typeProperties = typeof(T).GetProperties();
            var type = new T();

            int i = 0;
            while (reader.Read())
            {
                foreach (var property in typeProperties)
                {
                    PropertyInfo singleRow = typeof(T).GetProperty(property.Name);
                    i = reader.GetOrdinal(property.Name);
                    try
                    {
                        singleRow.SetValue(type, reader.GetValue(i), null);
                    }
                    catch
                    {
                        object value = property.Name.ToString() == "" ? Int32.Parse(reader.GetValue(i).ToString()) : default;
                        singleRow.SetValue(type, value, null);
                    }
                }
            }

            return type;
        }

        /// <summary>
        /// This method reads the whole table in the database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public List<T> ReadAll<T>() where T : IClassModel, new()
        {
            List<T> list = new List<T>();
            int id = 0;
            var action = connection.CreateCommand();
            action.CommandText = $"select * from {typeof(T).Name}"; 
            SqliteDataReader reader = action.ExecuteReader();  

            if (!reader.HasRows) 
            {
                throw new Exception(" Error. There are zero rows.");
            }

            while (reader.Read())  //for rows
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    if (reader.GetName(i).ToString() == "Id")
                    {
                        id = Int32.Parse(reader.GetValue(i).ToString());
                    }
                }


                list.Add(Read<T>(id));
            }

            return list;
        }

        /// <summary>
        /// This method gets the info and creates a new row with new data
        /// </summary>
        /// <param name="update"></param>
        public void Create(IClassModel update)
        {
            string updateColumn = "";
            string updateValue = "";
            PropertyInfo[] typeProperties = update.GetType().GetProperties();
            int i = 0;

            var action = connection.CreateCommand();  

            foreach (var property in typeProperties) 
            {
                if (property.Name.ToString() != "Id" && i == 1)
                {
                    updateColumn += " " + property.Name.ToString();
                    updateValue += " '" + property.GetValue(update).ToString() + "'";
                }
                if (property.Name.ToString() != "Id" && i > 1)
                {
                    updateColumn += ", " + property.Name.ToString();
                    updateValue += ", '" + property.GetValue(update).ToString() + "'";
                }
                i++;
            }
            action.CommandText = $"INSERT INTO {update.GetType().Name} ( {updateColumn} ) VALUES ( {updateValue} )";
            action.ExecuteNonQuery();
        }

        /// <summary>
        /// This method gets the info and updates any or all column in the row
        /// </summary>
        /// <param name="update"></param>
        public void Update(IClassModel update)
        {
            PropertyInfo[] typeProperties = update.GetType().GetProperties();
            string changeValue = "";
            int Id = 0;

            var action = connection.CreateCommand();

            foreach (var property in typeProperties)
            {
                if (property.Name.ToString() == "Id")
                {
                    Id = Int32.Parse(property.GetValue(update).ToString());
                    changeValue += " " + property.Name.ToString() + " = '" + property.GetValue(update).ToString() + "'";
                }
                else
                {
                    changeValue += ", " + property.Name.ToString() + " = '" + property.GetValue(update).ToString() + "'";
                }
            }
            action.CommandText = $"UPDATE {update.GetType().Name} SET {changeValue} WHERE id = {Id} ";
            action.ExecuteNonQuery();
        }

        /// <summary>
        /// This method gets the info and deletes the row that is being executed
        /// </summary>
        /// <param name="update"></param>
        public void Delete(IClassModel update)
        {
            PropertyInfo[] properties = update.GetType().GetProperties();
            var Id = 0;

            var action = connection.CreateCommand();

            foreach (var item in properties)
            {
                if (item.Name.ToString() == "Id")
                {
                    Id = Int32.Parse(item.GetValue(update).ToString());
                    break;
                }
            }
            action.CommandText = $"DELETE FROM {update.GetType().Name} WHERE id = {Id}"; 
            action.ExecuteNonQuery();
        }

        /// <summary>
        /// Closes the connection
        /// </summary>
        public void Dispose()
        {
            connection.Close();
        }
    }
}