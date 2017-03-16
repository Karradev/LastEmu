using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class LivingObjectMessageRequestMessage : NetworkMessage
	{
		public const uint Id = 6066;

		public uint msgId;

		public string[] parameters;

		public uint livingObject;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6066;
			}
		}

		public LivingObjectMessageRequestMessage()
		{
		}

		public LivingObjectMessageRequestMessage(uint msgId, string[] parameters, uint livingObject)
		{
			this.msgId = msgId;
			this.parameters = parameters;
			this.livingObject = livingObject;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.msgId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.parameters = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.parameters[i] = reader.ReadUTF();
			}
			this.livingObject = reader.ReadVarUhInt();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.msgId);
			writer.WriteShort((short)((int)this.parameters.Length));
			string[] strArrays = this.parameters;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				writer.WriteUTF(strArrays[i]);
			}
			writer.WriteVarInt((int)this.livingObject);
		}
	}
}