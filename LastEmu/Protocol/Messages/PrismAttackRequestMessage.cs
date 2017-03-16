using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class PrismAttackRequestMessage : NetworkMessage
	{
		public const uint Id = 6042;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6042;
			}
		}

		public PrismAttackRequestMessage()
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