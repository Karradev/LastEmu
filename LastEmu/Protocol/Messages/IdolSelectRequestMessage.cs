using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class IdolSelectRequestMessage : NetworkMessage
	{
		public const uint Id = 6587;

		public bool activate;

		public bool party;

		public uint idolId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6587;
			}
		}

		public IdolSelectRequestMessage()
		{
		}

		public IdolSelectRequestMessage(bool activate, bool party, uint idolId)
		{
			this.activate = activate;
			this.party = party;
			this.idolId = idolId;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.activate = BooleanByteWrapper.GetFlag(num, 0);
			this.party = BooleanByteWrapper.GetFlag(num, 1);
			this.idolId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.activate);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.party));
			writer.WriteVarShort((int)this.idolId);
		}
	}
}