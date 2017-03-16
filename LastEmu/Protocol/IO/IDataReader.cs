using System;
using System.IO;

namespace Protocol.IO
{
	public interface IDataReader : IDisposable
	{
		long BytesAvailable
		{
			get;
		}

		long Position
		{
			get;
		}

		bool ReadBoolean();

		byte ReadByte();

		byte[] ReadBytes(int n);

		char ReadChar();

		double ReadDouble();

		float ReadFloat();

		int ReadInt();

		long ReadLong();

		sbyte ReadSByte();

		short ReadShort();

		uint ReadUInt();

		ulong ReadULong();

		ushort ReadUShort();

		string ReadUTF();

		string ReadUTFBytes(ushort len);

		int ReadVarInt();

		double ReadVarLong();

		int ReadVarShort();

		uint ReadVarUhInt();

		double ReadVarUhLong();

		uint ReadVarUhShort();

		void Seek(int offset, SeekOrigin seekOrigin);

		void SkipBytes(int n);
	}
}