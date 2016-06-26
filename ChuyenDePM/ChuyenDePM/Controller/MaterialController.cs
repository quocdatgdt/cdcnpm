using ChuyenDePM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM.Controller
{
    class MaterialController
    {
        private ConnectServer conn;
        SqlDataReader reader;
        Material material;
        public MaterialController() {
            conn = new ConnectServer(Constants.server, Constants.user, Constants.password);
        }
        public List<Material> getListMaterial()
        {
            List<Material> materials = new List<Material>() { };
            conn.cmdSP.CommandText = "mysp_getListMaterial";
            conn.cmdSP.CommandType = CommandType.StoredProcedure;

            conn.openConnection();
            reader = conn.cmdSP.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    material = new Material();
                    material.id = reader.GetString(reader.GetOrdinal("MAVT"));
                    material.name = reader.GetString(reader.GetOrdinal("TENVT"));
                    material.unit = reader.GetString(reader.GetOrdinal("DVT"));
                    materials.Add(material);
                }
            }

            conn.closeConnection();
            return materials;
        }

        public bool deleteMaterial(Material material)
        {
            
            conn.cmdSP.CommandText = "mysp_deleteMaterialById";
            conn.cmdSP.CommandType = CommandType.StoredProcedure;

            conn.cmdSP.Parameters.Add(new SqlParameter("@MAVT", material.id));
            conn.openConnection();


            conn.cmdSP.ExecuteNonQuery();
            conn.closeConnection();
           
            return true;
        }
        public List<Material> searchMaterial(string code)
        {
            conn.cmdSP.CommandText = "mysp_searchMaterialById";
            conn.cmdSP.CommandType = CommandType.StoredProcedure;
            List<Material> materials = new List<Material>() { };
            conn.cmdSP.Parameters.Add(new SqlParameter("@MAVT", code));
            conn.openConnection();

            reader = conn.cmdSP.ExecuteReader();
            while (reader.Read())
            {
                material = new Material();
                material.id = reader.GetString(reader.GetOrdinal("MAVT"));
                material.name = reader.GetString(reader.GetOrdinal("TENVT"));
                material.unit = reader.GetString(reader.GetOrdinal("DVT"));
                materials.Add(material);
            }

            conn.closeConnection();
            return materials;
        }
    }
}
