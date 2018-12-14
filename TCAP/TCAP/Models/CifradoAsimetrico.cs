﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;

namespace TCAP.Models
{
    public class CifradoAsimetrico
    {

        public static string encryptString(String plainMessage, byte[] Key, byte[] IV)
        {
            // Crear una instancia del algoritmo de Rijndael

            Rijndael RijndaelAlg = Rijndael.Create();

            // Establecer un flujo en memoria para el cifrado

            MemoryStream memoryStream = new MemoryStream();

            // Crear un flujo de cifrado basado en el flujo de los datos

            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         RijndaelAlg.CreateEncryptor(Key, IV),
                                                         CryptoStreamMode.Write);

            // Obtener la representación en bytes de la información a cifrar

            byte[] plainMessageBytes = UTF8Encoding.UTF8.GetBytes(plainMessage);

            // Cifrar los datos enviándolos al flujo de cifrado

            cryptoStream.Write(plainMessageBytes, 0, plainMessageBytes.Length);

            cryptoStream.FlushFinalBlock();

            // Obtener los datos datos cifrados como un arreglo de bytes

            byte[] cipherMessageBytes = memoryStream.ToArray();

            // Cerrar los flujos utilizados

            memoryStream.Close();
            cryptoStream.Close();

            // Retornar la representación de texto de los datos cifrados

            return Convert.ToBase64String(cipherMessageBytes);
        }
        public static string decryptString(String encryptedMessage, byte[] Key, byte[] IV)
        {
            // Obtener la representación en bytes del texto cifrado

            byte[] cipherTextBytes = Convert.FromBase64String(encryptedMessage);

            // Crear un arreglo de bytes para almacenar los datos descifrados

            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            // Crear una instancia del algoritmo de Rijndael

            Rijndael RijndaelAlg = Rijndael.Create();

            // Crear un flujo en memoria con la representación de bytes de la información cifrada

            MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

            // Crear un flujo de descifrado basado en el flujo de los datos

            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         RijndaelAlg.CreateDecryptor(Key, IV),
                                                         CryptoStreamMode.Read);

            // Obtener los datos descifrados obteniéndolos del flujo de descifrado

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);

            // Cerrar los flujos utilizados

            memoryStream.Close();
            cryptoStream.Close();

            // Retornar la representación de texto de los datos descifrados

            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
        }
        public static void encryptToFile(String plainMessage, String filename, byte[] Key, byte[] IV)
        {
            // Crear un flujo para el archivo a generarse

            FileStream fileStream = File.Open(filename, FileMode.OpenOrCreate);

            // Crear una instancia del algoritmo Rijndael

            Rijndael RijndaelAlg = Rijndael.Create();

            // Crear un flujo de cifrado basado en el flujo de los datos

            CryptoStream cryptoStream = new CryptoStream(fileStream,
                                                         RijndaelAlg.CreateEncryptor(Key, IV),
                                                         CryptoStreamMode.Write);

            // Crear un flujo de escritura basado en el flujo de cifrado

            StreamWriter streamWriter = new StreamWriter(cryptoStream);

            // Cifrar el mensaje a través del flujo de escritura

            streamWriter.WriteLine(plainMessage);

            // Cerrar los flujos utilizados

            streamWriter.Close();
            cryptoStream.Close();
            fileStream.Close();
        }
        public static string decryptFromFile(String filename, byte[] Key, byte[] IV)
        {
            // Crear un flujo para el archivo a generarse

            FileStream fileStream = File.Open(filename, FileMode.OpenOrCreate);

            // Crear una instancia del algoritmo Rijndael

            Rijndael RijndaelAlg = Rijndael.Create();

            // Crear un flujo de cifrado basado en el flujo de los datos

            CryptoStream cryptoStream = new CryptoStream(fileStream,
                                                         RijndaelAlg.CreateDecryptor(Key, IV),
                                                         CryptoStreamMode.Read);

            // Crear un flujo de lectura basado en el flujo de cifrado

            StreamReader streamReader = new StreamReader(cryptoStream);

            // Descifrar el mensaje a través del flujo de lectura

            string plainMessage = streamReader.ReadLine();

            // Cerrar los flujos utilizados

            streamReader.Close();
            cryptoStream.Close();
            fileStream.Close();

            return plainMessage;
        }
    }

}