using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SystemMessageDisplayMessage : NetworkMessage
	{
		public const uint Id = 189;

		public bool hangUp;

		public uint msgId;

		public string[] parameters;

		public override uint ProtocolId
		{
			get
			{
				return (uint)189;
			}
		}

		public SystemMessageDisplayMessage()
		{
		}

		public SystemMessageDisplayMessage(bool hangUp, uint msgId, string[] parameters)
		{
			this.hangUp = hangUp;
			this.msgId = msgId;
			this.parameters = parameters;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.hangUp = reader.ReadBoolean();
			this.msgId = reader.ReadVarUhShort();
			ushort num = reader.ReadUShort();
			this.parameters = new string[num];
			for (int i = 0; i < num; i++)
			{
				this.parameters[i] = reader.ReadUTF();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.hangUp);
			writer.WriteVarShort((int)this.msgId);
			writer.WriteShort((short)((int)this.parameters.Length));
			string[] strArrays = this.parameters;
			for (int i = 0; i < (int)strArrays.Length; i++)
			{
				writer.WriteUTF(strArrays[i]);
			}
		}
	}
}