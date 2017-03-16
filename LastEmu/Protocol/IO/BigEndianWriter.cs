using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Protocol.IO
{
    public class BigEndianWriter : IDataWriter, IDisposable
    {
        private BinaryWriter _mWriter;

        public BigEndianWriter()
        {
            _mWriter = new BinaryWriter(new MemoryStream(), Encoding.UTF8);
        }

        public BigEndianWriter(Stream stream)
        {
            _mWriter = new BinaryWriter(stream, Encoding.UTF8);
        }

        public BigEndianWriter(byte[] buffer)
        {
            _mWriter = new BinaryWriter(new MemoryStream(buffer));
        }

        public Stream BaseStream => _mWriter.BaseStream;

        public long BytesAvailable
        {
            get
            {
                var length = _mWriter.BaseStream.Length - _mWriter.BaseStream.Position;
                return length;
            }
        }

        public long Position
        {
            get { return _mWriter.BaseStream.Position; }
            set { _mWriter.BaseStream.Position = value; }
        }

        public byte[] Data
        {
            get
            {
                var position = _mWriter.BaseStream.Position;
                var numArray = new byte[(int) (IntPtr) _mWriter.BaseStream.Length];
                _mWriter.BaseStream.Position = 0;
                _mWriter.BaseStream.Read(numArray, 0, (int) _mWriter.BaseStream.Length);
                _mWriter.BaseStream.Position = position;
                return numArray;
            }
        }

        public void Clear() => _mWriter = new BinaryWriter(new MemoryStream(), Encoding.UTF8);

        public void WriteBoolean(bool @bool)
        {
            if (!@bool)
                _mWriter.Write((byte) 0);
            else
                _mWriter.Write((byte) 1);
        }

        public void WriteByte(byte @byte) => _mWriter.Write(@byte);

        public void WriteBytes(byte[] data) => _mWriter.Write(data);

        public void WriteBytes(byte[] data, uint offset, uint length)
        {
            var numArray = new byte[length];
            Array.Copy(data, offset, numArray, 0, length);
            _mWriter.Write(numArray);
        }

        public void WriteChar(char @char) => WriteBigEndianBytes(BitConverter.GetBytes(@char));

        public void WriteDouble(double @double) => WriteBigEndianBytes(BitConverter.GetBytes(@double));

        public void WriteFloat(float @float) => _mWriter.Write(@float);

        public void WriteInt(int @int) => WriteBigEndianBytes(BitConverter.GetBytes(@int));

        public void WriteLong(long @long) => WriteBigEndianBytes(BitConverter.GetBytes(@long));

        public void WriteSByte(sbyte @byte) => _mWriter.Write(@byte);

        public void WriteShort(short @short) => WriteBigEndianBytes(BitConverter.GetBytes(@short));

        public void WriteSingle(float single) => WriteBigEndianBytes(BitConverter.GetBytes(single));

        public void WriteUInt(uint @uint) => WriteBigEndianBytes(BitConverter.GetBytes(@uint));

        public void WriteULong(ulong @ulong) => WriteBigEndianBytes(BitConverter.GetBytes(@ulong));

        public void WriteUShort(ushort @ushort) => WriteBigEndianBytes(BitConverter.GetBytes(@ushort));

        public void WriteUTF(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var length = (ushort) bytes.Length;
            WriteUShort(length);
            for (var i = 0; i < length; i++)
                _mWriter.Write(bytes[i]);
        }

        public void WriteUTFBytes(string str)
        {
            var bytes = Encoding.UTF8.GetBytes(str);
            var length = bytes.Length;
            for (var i = 0; i < length; i++)
                _mWriter.Write(bytes[i]);
        }

        public void WriteVarInt(int @int)
        {
            var bigEndianWriter = new BigEndianWriter();
            if (@int < 0 || @int > 127)
            {
                var num1 = @int;
                var bigEndianWriter1 = new BigEndianWriter();
                while (num1 != 0)
                {
                    bigEndianWriter1.WriteByte((byte) (num1 & 127));
                    var bigEndianReader = new BigEndianReader(bigEndianWriter1.Data);
                    int num = bigEndianReader.ReadByte();
                    bigEndianWriter1 = new BigEndianWriter(bigEndianReader.Data);
                    num1 = num1 >> 7;
                    if (num1 > 0)
                        num = num | 128;
                    bigEndianWriter.WriteByte((byte) num);
                }
                WriteBytes(bigEndianWriter.Data);
            }
            else
            {
                bigEndianWriter.WriteByte((byte) @int);
                WriteBytes(bigEndianWriter.Data);
            }
        }

        public void WriteVarLong(double @double)
        {
            var low = FinalInt64.FromNumber(@double);
            if (low.High != 0)
            {
                for (var i = 0; i < 4; i++)
                {
                    WriteByte((byte) ((uint) low.Low & 127 | 128));
                    low.Low = (long) low.Low >> 7;
                }
                if ((low.High & 2147483640) != 0)
                {
                    WriteByte((byte) ((low.High << 4 | (uint) low.Low) & 127 | 128));
                    WriteInt32((uint) (low.High >> 3));
                }
                else
                {
                    WriteByte((byte) (low.High << 4 | (uint) low.Low));
                }
            }
            else
            {
                WriteInt32((uint) low.Low);
            }
        }

        public void WriteVarShort(int @int)
        {
            if (@int > 32767 || @int < -32768)
                throw new Exception("Forbidden value");
            var bigEndianWriter = new BigEndianWriter();
            if (@int < 0 || @int > 127)
            {
                var num1 = @int & 65535;
                var bigEndianWriter1 = new BigEndianWriter();
                while (num1 != 0)
                {
                    bigEndianWriter1.WriteByte((byte) (num1 & 127));
                    var bigEndianReader = new BigEndianReader(bigEndianWriter1.Data);
                    int num = bigEndianReader.ReadByte();
                    bigEndianWriter1 = new BigEndianWriter(bigEndianReader.Data);
                    num1 = num1 >> 7;
                    if (num1 > 0)
                        num = num | 128;
                    bigEndianWriter.WriteByte((byte) num);
                }
                WriteBytes(bigEndianWriter.Data);
            }
            else
            {
                bigEndianWriter.WriteByte((byte) @int);
                WriteBytes(bigEndianWriter.Data);
            }
        }

        public void Dispose()
        {
            _mWriter.Dispose();
            _mWriter = null;
        }

        public void Seek(int offset, SeekOrigin seekOrigin) => _mWriter.BaseStream.Seek(offset, seekOrigin);

        private void WriteBigEndianBytes(IReadOnlyList<byte> endianBytes)
        {
            for (var i = endianBytes.Count - 1; i >= 0; i--)
                _mWriter.Write(endianBytes[i]);
        }

        public void WriteInt32(uint param1)
        {
            while (param1 >= 128)
            {
                WriteByte((byte) (param1 & 127 | 128));
                param1 = param1 >> 7;
            }
            WriteByte((byte) param1);
        }
    }
}