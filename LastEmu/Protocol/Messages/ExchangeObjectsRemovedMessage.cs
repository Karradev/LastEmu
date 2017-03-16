using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class ExchangeObjectsRemovedMessage : ExchangeObjectMessage
	{
		public const uint Id = 6532;

		public uint[] objectUID;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6532;
			}
		}

		public ExchangeObjectsRemovedMessage()
		{
		}

		public ExchangeObjectsRemovedMessage(bool remote, uint[] objectUID) : base(remote)
		{
			this.objectUID = objectUID;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			ushort num = reader.ReadUShort();
			this.objectUID = new uint[num];
			for (int i = 0; i < num; i++)
			{
				this.objectUID[i] = reader.ReadVarUhInt();
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteShort((short)((int)this.objectUID.Length));
			uint[] numArray = this.objectUID;
			for (int i = 0; i < (int)numArray.Length; i++)
			{
				writer.WriteVarInt((int)numArray[i]);
			}
		}
	}
}