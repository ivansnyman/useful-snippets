//Get Combobox selected item as string value without issues
string selected = this.ComboBox.GetItemText(this.ComboBox.SelectedItem);


//Save record to SQL Server DB with best practices and auto garbage collection
using (SqlConnection myConnection = new SqlConnection(ConStr))
            {
                string sqlQuery = "INSERT INTO [tableName] (param1,param2,param3...) VALUES(@var1,@var2,@var3...)";
                using (SqlCommand queryName = new SqlCommand(queryName))
                {
                    queryName.Connection = myConnection;
                    queryName.Parameters.Add("@param1", SqlDbType.NVarChar, 50).Value = var1;
                    queryName.Parameters.Add("@param2", SqlDbType.NVarChar, int.MaxValue).Value = var2;
                    queryName.Parameters.Add("@param3", SqlDbType.DateTime).Value = var3;
                    try
                    {
                        myConnection.Open();
                        queryName.ExecuteNonQuery();
                        MessageBox.Show("Successfully saved to the database");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error message:\n\n" + ex.ToString(), "ERROR");
                    }
                }
            }

