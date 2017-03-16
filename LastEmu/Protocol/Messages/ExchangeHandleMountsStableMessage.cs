using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class ExchangeHandleMountsStableMessage : NetworkMessage
	{
		public const uint Id = 6562;

		public sbyte actionType;

		public uint[] ridesId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6562;
			}
		}

		public ExchangeHandleMountsStableMessage()
		{
		}

		public ExchangeHandleMountsStableMessage(sbyte actionType, uint[] ridesId)
		{
			this.actionType = actionType;
			this.ridesId = ridesId;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.actionType = reader.ReadSByte();
			ushort num = reader.ReadUShort();
			this.ridesId = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.ridesId[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.actionType);
			writer.WriteShort((short)((int)this.ridesId.Length));
			uint[] numArray = this.ridesId;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}