using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class IdolSelectErrorMessage : NetworkMessage
	{
		public const uint Id = 6584;

		public bool activate;

		public bool party;

		public sbyte reason;

		public uint idolId;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6584;
			}
		}

		public IdolSelectErrorMessage()
		{
		}

		public IdolSelectErrorMessage(bool activate, bool party, sbyte reason, uint idolId)
		{
			this.activate = activate;
			this.party = party;
			this.reason = reason;
			this.idolId = idolId;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.activate = BooleanByteWrapper.GetFlag(num, 0);
			this.party = BooleanByteWrapper.GetFlag(num, 1);
			this.reason = reader.ReadSByte();
			this.idolId = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.activate);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.party));
			writer.WriteSByte(this.reason);
			writer.WriteVarShort((int)this.idolId);
		}
	}
}