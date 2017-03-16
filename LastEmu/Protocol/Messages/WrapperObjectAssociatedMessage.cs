using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class WrapperObjectAssociatedMessage : SymbioticObjectAssociatedMessage
	{
		public const uint Id = 6523;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6523;
			}
		}

		public WrapperObjectAssociatedMessage()
		{
		}

		public WrapperObjectAssociatedMessage(uint hostUID) : base(hostUID)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}