using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class FinishMoveListRequestMessage : NetworkMessage
	{
		public const uint Id = 6702;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6702;
			}
		}

		public FinishMoveListRequestMessage()
		{
		}

		public override void Deserialize(IDataReader reader)
		{
		}

		public override void Serialize(IDataWriter writer)
		{
		}
	}
}