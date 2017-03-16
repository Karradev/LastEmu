using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class IgnoredGetListMessage : NetworkMessage
	{
		public const uint Id = 5676;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5676;
			}
		}

		public IgnoredGetListMessage()
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