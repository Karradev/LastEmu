using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ServerOptionalFeaturesMessage : NetworkMessage
	{
		public const uint Id = 6305;

		public sbyte[] features;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6305;
			}
		}

		public ServerOptionalFeaturesMessage()
		{
		}

		public ServerOptionalFeaturesMessage(sbyte[] features)
		{
			this.features = features;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = (ushort)reader.ReadVarInt();
			this.features = new sbyte[num];
			for (int i = 0; i < num; i++)
			{
				this.features[i] = reader.ReadSByte();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarInt((int)((int)this.features.Length));
			sbyte[] numArray = this.features;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteSByte(numArray[i]);
			}
		}
	}
}