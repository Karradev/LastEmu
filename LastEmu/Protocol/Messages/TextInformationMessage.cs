using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TextInformationMessage : NetworkMessage
	{
		public const uint Id = 780;

		public sbyte msgType;

		public uint msgId;

		public string[] parameters;

		public override uint ProtocolId
		{
			get
			{
				return (uint)780;
			}
		}

		public TextInformationMessage()
		{
		}

		public TextInformationMessage(sbyte msgType, uint msgId, string[] parameters)
		{
			this.msgType = msgType;
			this.msgId = msgId;
			this.parameters = parameters;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.msgType = reader.ReadSByte();
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
			writer.WriteSByte(this.msgType);
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