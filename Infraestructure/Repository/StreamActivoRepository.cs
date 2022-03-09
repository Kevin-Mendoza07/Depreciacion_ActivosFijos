﻿using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class StreamActivoRepository : IActivoModel
    {        
        private StreamReader binaryReader;
        private StreamWriter binaryWriter;
        private string fileName = "activo.dat";
        public StreamActivoRepository()
        {
            
        }
        public void Add(Activo t)
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    binaryWriter = new StreamWriter(fileStream);
                    binaryWriter.Write(t.Id);
                    binaryWriter.Write(t.Nombre);
                    binaryWriter.Write(t.Valor);
                    binaryWriter.Write(t.VidaUtil);
                    binaryWriter.Write(t.ValorResidual);

                    binaryWriter.Close();
                }

            }
            catch (IOException)
            {
                throw;
            }
        }

        public void Delete(Activo t)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Activo> Read()
        {
            List<Activo> activos = new List<Activo>();
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    binaryReader = new StreamReader(fileStream);

                    while (!binaryReader.EndOfStream)
                    {

                    }
                   
                    //binaryReader.BaseStream.
                    //binaryWriter.Write(t.Id);
                    //binaryWriter.Write(t.Nombre);
                    //binaryWriter.Write(t.Valor);
                    //binaryWriter.Write(t.VidaUtil);
                    //binaryWriter.Write(t.ValorResidual);

                    binaryWriter.Close();
                }
                return activos; 
            }
            catch (IOException)
            {
                throw;
            }
        }
    }
}
