using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class TitlesAndOrnamentsListRequestMessage : NetworkMessage
	{
		public const uint Id = 6363;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6363;
			}
		}

		public TitlesAndOrnamentsListRequestMessage()
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