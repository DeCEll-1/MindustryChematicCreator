using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindustryChematicCreator
{
    internal class CompressionUtils
    {
        internal static byte[] Compress(byte[] data)
        {
            using MemoryStream ms = new MemoryStream();
            using (var zlib = new ZLibStream(ms, CompressionLevel.Optimal))
            { // need a header
                zlib.Write(data, 0, data.Length);
            }
            return ms.ToArray();
        }

        internal static byte[] Decompress(byte[] compressedData)
        {
            using MemoryStream compressedStream = new MemoryStream(compressedData);
            using var zlib = new ZLibStream(compressedStream, CompressionMode.Decompress);
            using MemoryStream decompressedStream = new MemoryStream();

            zlib.CopyTo(decompressedStream);
            return decompressedStream.ToArray();
        }
    }

}
