﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGames
{
    internal class Conexao
    {
            //INSTANCIANDO MYSQL
            MySqlConnection con = new MySqlConnection("Data Source=localhost;Initial Catalog=BDProjetoGame;user=root;pwd=12345678");

            public static string msg;

            public MySqlConnection ConnectarBD()
            {
                try
                {
                    con.Open();

                }
                catch (Exception erro)
                {

                    msg = "Ocorreu um erro ao se conectar" + erro.Message;
                }
                return con;
            }

            public MySqlConnection DesConnectarBD()
            {
                try
                {
                    con.Close();

                }
                catch (Exception erro)
                {

                    msg = "Ocorreu um erro ao se conectar" + erro.Message;
                }
                return con;
            }
        }
    }

