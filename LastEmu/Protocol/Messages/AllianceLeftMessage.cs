using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class AllianceLeftMessage : NetworkMessage
	{
		public const uint Id = 6398;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6398;
			}
		}

		public AllianceLeftMessage()
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