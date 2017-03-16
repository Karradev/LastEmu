using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismFightJoinLeaveRequestMessage : NetworkMessage
	{
		public const uint Id = 5843;

		public uint subAreaId;

		public bool @join;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5843;
			}
		}

		public PrismFightJoinLeaveRequestMessage()
		{
		}

		public PrismFightJoinLeaveRequestMessage(uint subAreaId, bool join)
		{
			this.subAreaId = subAreaId;
			this.@join = join;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.subAreaId = reader.ReadVarUhShort();
			this.@join = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteBoolean(this.@join);
		}
	}
}