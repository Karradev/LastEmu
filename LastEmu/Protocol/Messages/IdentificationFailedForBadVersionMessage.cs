using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IdentificationFailedForBadVersionMessage : IdentificationFailedMessage
	{
		public const uint Id = 21;

		public Types.Version requiredVersion;

		public override uint ProtocolId
		{
			get
			{
				return (uint)21;
			}
		}

		public IdentificationFailedForBadVersionMessage()
		{
		}

		public IdentificationFailedForBadVersionMessage(sbyte reason, Types.Version requiredVersion) : base(reason)
		{
			this.requiredVersion = requiredVersion;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.requiredVersion = new Types.Version();
			this.requiredVersion.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.requiredVersion.Serialize(writer);
		}
	}
}