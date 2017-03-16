using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GetPartsListMessage : NetworkMessage
	{
		public const uint Id = 1501;

		public override uint ProtocolId
		{
			get
			{
				return (uint)1501;
			}
		}

		public GetPartsListMessage()
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