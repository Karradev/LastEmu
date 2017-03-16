using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class SpellModifyFailureMessage : NetworkMessage
	{
		public const uint Id = 6653;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6653;
			}
		}

		public SpellModifyFailureMessage()
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