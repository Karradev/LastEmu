namespace Protocol.IO
{
	public interface IDataWriter
	{
		byte[] Data
		{
			get;
		}

		void Clear();

		void WriteBoolean(bool @bool);

		void WriteByte(byte @byte);

		void WriteBytes(byte[] data);

		void WriteBytes(byte[] data, uint offset, uint length);

		void WriteChar(char @char);

		void WriteDouble(double @double);

		void WriteFloat(float @float);

		void WriteInt(int @int);

		void WriteLong(long @long);

		void WriteSByte(sbyte @byte);

		void WriteShort(short @short);

		void WriteSingle(float single);

		void WriteUInt(uint @uint);

		void WriteULong(ulong @ulong);

		void WriteUShort(ushort @ushort);

		void WriteUTF(string str);

		void WriteUTFBytes(string str);

		void WriteVarInt(int @int);

		void WriteVarLong(double @double);

		void WriteVarShort(int @int);
	}
}