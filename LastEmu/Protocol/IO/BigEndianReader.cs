using System;
using System.IO;
using System.Text;

namespace Protocol.IO
{
    public class BigEndianReader : IDataReader, IDisposable
    {
        private BinaryReader _mReader;

        public BigEndianReader()
        {
            _mReader = new BinaryReader(new MemoryStream(), Encoding.UTF8);
        }

        public BigEndianReader(Stream stream)
        {
            _mReader = new BinaryReader(stream, Encoding.UTF8);
        }

        public BigEndianReader(byte[] tab)
        {
            _mReader = new BinaryReader(new MemoryStream(tab), Encoding.UTF8);
        }

        public Stream BaseStream => _mReader.BaseStream;

        public byte[] Data
        {
            get
            {
                var position = BaseStream.Position;
                var numArray = new byte[(int) (IntPtr) BaseStream.Length];
                BaseStream.Position = 0;
                BaseStream.Read(numArray, 0, (int) BaseStream.Length);
                BaseStream.Position = position;
                return numArray;
            }
        }

        public long BytesAvailable
        {
            get
            {
                var length = _mReader.BaseStream.Length - _mReader.BaseStream.Position;
                return length;
            }
        }

        public long Position => _mReader.BaseStream.Position;

        public void Dispose()
        {
            _mReader.Dispose();
            _mReader = null;
        }

        public bool ReadBoolean() => _mReader.ReadByte() == 1;

        public byte ReadByte() => _mReader.ReadByte();

        public byte[] ReadBytes(int n) => _mReader.ReadBytes(n);

        public char ReadChar() => (char) ReadUShort();

        public double ReadDouble() => BitConverter.ToDouble(ReadBigEndianBytes(8), 0);

        public float ReadFloat() => BitConverter.ToSingle(ReadBigEndianBytes(4), 0);

        public int ReadInt() => BitConverter.ToInt32(ReadBigEndianBytes(4), 0);

        public long ReadLong() => BitConverter.ToInt64(ReadBigEndianBytes(8), 0);

        public sbyte ReadSByte() => _mReader.ReadSByte();

        public short ReadShort() => BitConverter.ToInt16(ReadBigEndianBytes(2), 0);

        public uint ReadUInt() => BitConverter.ToUInt32(ReadBigEndianBytes(4), 0);

        public ulong ReadULong() => BitConverter.ToUInt64(ReadBigEndianBytes(8), 0);

        public ushort ReadUShort() => BitConverter.ToUInt16(ReadBigEndianBytes(2), 0);

        public string ReadUTF()
        {
            var numArray = ReadBytes(ReadUShort());
            return Encoding.UTF8.GetString(numArray);
        }

        public string ReadUTFBytes(ushort len)
        {
            var numArray = ReadBytes(len);
            return Encoding.UTF8.GetString(numArray);
        }

        public int ReadVarInt()
        {
            var num1 = 0;
            var num2 = 0;
            while (num2 < 32)
            {
                int num = ReadByte();
                var flag = (num & 128) == 128;
                num1 = num2 <= 0 ? num1 + (num & 127) : num1 + ((num & 127) << (num2 & 31));
                num2 = num2 + 7;
                if (!flag)
                    return num1;
            }
            throw new Exception("Too much data");
        }

        public double ReadVarLong() => ReadVarInt64(this).ToNumber();

        public int ReadVarShort()
        {
            var num1 = 0;
            var num2 = 0;
            while (num2 < 16)
            {
                int num = ReadByte();
                var flag = (num & 128) == 128;
                num1 = num2 <= 0 ? num1 + (num & 127) : num1 + ((num & 127) << (num2 & 31));
                num2 = num2 + 7;
                if (flag) continue;
                if (num1 > 32767)
                    num1 = num1 - 65536;
                return num1;
            }
            throw new Exception("Too much data");
        }

        public uint ReadVarUhInt() => (uint) ReadVarInt();

        public double ReadVarUhLong() => ReadVarUInt64(this).ToNumber();

        public uint ReadVarUhShort() => (uint) ReadVarShort();

        public void Seek(int offset, SeekOrigin seekOrigin) => _mReader.BaseStream.Seek(offset, seekOrigin);

        public void SkipBytes(int n)
        {
            for (var i = 0; i < n; i++)
                _mReader.ReadByte();
        }

        public void Add(byte[] data, int offset, int count)
        {
            var position = _mReader.BaseStream.Position;
            _mReader.BaseStream.Position = _mReader.BaseStream.Length;
            _mReader.BaseStream.Write(data, offset, count);
            _mReader.BaseStream.Position = position;
        }

        public void Close() => BaseStream.Close();

        private byte[] ReadBigEndianBytes(int count)
        {
            var numArray = new byte[count];
            for (var i = count - 1; i >= 0; i--)
                numArray[i] = (byte) BaseStream.ReadByte();
            return numArray;
        }

        public BigEndianReader ReadBytesInNewBigEndianReader(int n) => new BigEndianReader(_mReader.ReadBytes(n));

        public short ReadInt16() => ReadShort();

        public int ReadInt32() => ReadInt();

        public long ReadInt64() => ReadLong();

        public float ReadSingle() => BitConverter.ToSingle(ReadBigEndianBytes(4), 0);

        public string ReadString() => ReadUTF();

        public ushort ReadUInt16() => ReadUShort();

        public uint ReadUInt32() => ReadUInt();

        public ulong ReadUInt64() => ReadULong();

        public string ReadUTF7BitLength()
        {
            var numArray = ReadBytes(ReadInt());
            return Encoding.UTF8.GetString(numArray);
        }

        public FinalInt64 ReadVarInt64(BigEndianReader reader)
        {
            FinalInt64 finalInt64;
            var low = new FinalInt64();
            var num1 = 0;
            while (true)
            {
                int num = reader.ReadByte();
                if (num1 == 28)
                {
                    if (num < 128)
                    {
                        low.Low = (int) low.Low | num << (num1 & 31);
                        low.High = num >> 4;
                        finalInt64 = low;
                        break;
                    }
                    num = num & 127;
                    low.Low = (uint) low.Low | num << (num1 & 31);
                    low.High = num >> 4;
                    num1 = 3;
                    while (true)
                    {
                        num = reader.ReadByte();
                        if (num1 < 32)
                        {
                            if (num < 128)
                                break;
                            low.High = low.High | (num & 127) << (num1 & 31);
                        }
                        num1 = num1 + 7;
                    }
                    low.High = low.High | num << (num1 & 31);
                    finalInt64 = low;
                    break;
                }
                if (num < 128)
                {
                    low.Low = (uint) low.Low | num << (num1 & 31);
                    finalInt64 = low;
                    break;
                }
                low.Low = (uint) low.Low | (num & 127) << (num1 & 31);
                num1 = num1 + 7;
            }
            return finalInt64;
        }

        public FinalUInt64 ReadVarUInt64(BigEndianReader reader)
        {
            FinalUInt64 finalUInt64;
            var low = new FinalUInt64();
            var num1 = 0;
            while (true)
            {
                int num = reader.ReadByte();
                if (num1 == 28)
                {
                    if (num < 128)
                    {
                        low.Low = (uint) (low.Low | num << (num1 & 31));
                        low.High = (uint) (num >> 4);
                        finalUInt64 = low;
                        break;
                    }
                    num = num & 127;
                    low.Low = (uint) (low.Low | num << (num1 & 31));
                    low.High = (uint) (num >> 4);
                    num1 = 3;
                    while (true)
                    {
                        num = reader.ReadByte();
                        if (num1 < 32)
                        {
                            if (num < 128)
                                break;
                            low.High = (uint) (low.High | (num & 127) << (num1 & 31));
                        }
                        num1 = num1 + 7;
                    }
                    low.High = (uint) (low.High | num << (num1 & 31));
                    finalUInt64 = low;
                    break;
                }
                if (num < 128)
                {
                    low.Low = (uint) (low.Low | num << (num1 & 31));
                    finalUInt64 = low;
                    break;
                }
                low.Low = (uint) (low.Low | (num & 127) << (num1 & 31));
                num1 = num1 + 7;
            }
            return finalUInt64;
        }

        public void SetPosition(int Position) => Seek(Position, SeekOrigin.Begin);
    }
}