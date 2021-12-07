using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;

    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }

    //async call that will return task of type enumerable of type T in this case UserModel
    public async Task<IEnumerable<T>> LoadData<T, U>(
        string storedProcedure,
        U parameters,
        string connectionId = "Default") //The name of the connection string in the appsettings.json
    {
        //This using statement tells the system to shut down after the end of the method
        //You dont want to leave a connection open when talking to a database
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        //talks to our connection(sql) and says execute store procedure with these parameters & it is going to return the Ienumerable of ype <T>
        return await connection.QueryAsync<T>(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure);
    }

    public async Task SaveData<T>(
        string storedProcedure,//Can be our insert, delete, update
        T parameters,
        string connectionId = "Default")
    {
        using IDbConnection connection = new SqlConnection(_config.GetConnectionString(connectionId));

        await connection.ExecuteAsync(storedProcedure, parameters,
            commandType: CommandType.StoredProcedure); //This is saying yes this is a stored procedure not just sql text written in c#
    }
}
