using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class HelloConnectMessage : NetworkMessage
	{
		public const uint Id = 3;

		public string salt;

		public sbyte[] key;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3;
			}
		}

		public HelloConnectMessage()
		{
		}

		public HelloConnectMessage(string salt, sbyte[] key)
		{
			this.salt = salt;
			this.key = key;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.salt = reader.ReadUTF();
			ushort num = (ushort)reader.ReadVarInt();
			this.key = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.key[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteUTF(this.salt);
			writer.WriteVarInt((int)((int)this.key.Length));
			sbyte[] numArray = this.key;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}