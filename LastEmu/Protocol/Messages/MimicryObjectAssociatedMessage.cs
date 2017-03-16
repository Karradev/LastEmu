using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class MimicryObjectAssociatedMessage : SymbioticObjectAssociatedMessage
	{
		public const uint Id = 6462;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6462;
			}
		}

		public MimicryObjectAssociatedMessage()
		{
		}

		public MimicryObjectAssociatedMessage(uint hostUID) : base(hostUID)
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