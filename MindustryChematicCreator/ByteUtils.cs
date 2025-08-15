using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindustryChematicCreator
{
    internal class ByteUtils
    {
        #region write
        public static void WriteUTF(BinaryWriter writer, string text)
        {
            byte[] textBytes = Encoding.UTF8.GetBytes(text);
            byte[] len = new byte[2]; // because ofcourse, it cant be simple
            BinaryPrimitives.WriteUInt16BigEndian(len, (ushort)textBytes.Length);
            writer.Write(len);
            writer.Write(textBytes);
        }
        public static void WriteInt32BigEndian(BinaryWriter writer, int value)
        {
            byte[] bytes = new byte[4];
            BinaryPrimitives.WriteInt32BigEndian(bytes, value);
            writer.Write(bytes);
        }

        public static void WriteUInt32BigEndian(BinaryWriter writer, uint value)
        {
            byte[] bytes = new byte[4];
            BinaryPrimitives.WriteUInt32BigEndian(bytes, value);
            writer.Write(bytes);
        }

        public static void WriteInt16BigEndian(BinaryWriter writer, short value)
        {
            byte[] bytes = new byte[2];
            BinaryPrimitives.WriteInt16BigEndian(bytes, value);
            writer.Write(bytes);
        }

        public static void WriteUInt16BigEndian(BinaryWriter writer, ushort value)
        {
            byte[] bytes = new byte[2];
            BinaryPrimitives.WriteUInt16BigEndian(bytes, value);
            writer.Write(bytes);
        }
        #endregion

        #region read
        public static string ReadUTF(BinaryReader reader)
        {
            ushort length = ReadUInt16BigEndian(reader);
            byte[] bytes = reader.ReadBytes(length);
            return Encoding.UTF8.GetString(bytes);
        }

        public static int ReadInt32BigEndian(BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(4);
            return BinaryPrimitives.ReadInt32BigEndian(bytes);
        }

        public static uint ReadUInt32BigEndian(BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(4);
            return BinaryPrimitives.ReadUInt32BigEndian(bytes);
        }

        public static short ReadInt16BigEndian(BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(2);
            return BinaryPrimitives.ReadInt16BigEndian(bytes);
        }

        public static ushort ReadUInt16BigEndian(BinaryReader reader)
        {
            byte[] bytes = reader.ReadBytes(2);
            return BinaryPrimitives.ReadUInt16BigEndian(bytes);
        }

        #endregion
    }
}
