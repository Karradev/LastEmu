using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class EntityTalkMessage : NetworkMessage
	{
		public const uint Id = 6110;

		public double entityId;

		public uint textId;

		public string[] parameters;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6110;
			}
		}

		public EntityTalkMessage()
		{
		}

		public EntityTalkMessage(double entityId, uint textId, string[] parameters)
		{
			this.entityId = entityId;
			this.textId = textId;
			this.parameters = parameters;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.entityId = reader.ReadDouble();
			this.textId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.parameters = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.parameters[i] = reader.ReadUTF();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteDouble(this.entityId);
			writer.WriteVarShort((int)this.textId);
			writer.WriteShort((short)((int)this.parameters.Length));
			string[] strArrays = this.parameters;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				writer.WriteUTF(strArrays[i]);
			}
		}
	}
}