using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismInfoJoinLeaveRequestMessage : NetworkMessage
	{
		public const uint Id = 5844;

		public bool @join;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5844;
			}
		}

		public PrismInfoJoinLeaveRequestMessage()
		{
		}

		public PrismInfoJoinLeaveRequestMessage(bool join)
		{
			this.@join = join;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.@join = reader.ReadBoolean();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.@join);
		}
	}
}